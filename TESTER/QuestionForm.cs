﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TESTER
{
    public partial class QuestionForm : Form
    {
        public QuestionForm(/*RegisterForm Form1*/)
        {
            InitializeComponent();
            //RegisterForm = Form1;
            ResultForm = new ResultForm(this);
        }

        //Инициализация глобальных переменных
#region GlobalVariables
        //RegisterForm RegisterForm; //форма регистрации  
        ResultForm ResultForm; //форма результатов
        public XML_USER xmlUser; //XML пользователя
        XML_TEST XmlTest = new XML_TEST(); //XML теста
        Label QuestionLabel = new Label(){ //Поле для вопроса
            Size = new Size(750, 80),
            Location = new Point(5, 15),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            Font = new Font("Tahoma", 12.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)))
        };
        TextBox AnsTB; //Текстбокс для ответа
        List<RadioButton> AnsRB = new List<RadioButton>(); //Радиобатоны ответов
        List<CheckBox> AnsCB = new List<CheckBox>(); //Чекбоксы ответов
        int K = 0; // Номер текущего вопроса
#endregion

        //Загрузка формы
        private void QuestionForm_Load(object sender, EventArgs e){
            this.WindowState = FormWindowState.Maximized;
            /*FIO.Text = RegisterForm.FIO_TextBox.Text;
            EI.Text = RegisterForm.EI_CB.Text;
            Subject.Text = RegisterForm.Subject_CB.Text;
            TestName.Text = RegisterForm.Test_CB.Text;*/
            FIO.Text = xmlUser.FIO;
            EI.Text = xmlUser.EI;
            Subject.Text = xmlUser.Science;
            TestName.Text = xmlUser.Theme;
            XmlTest.DeSerialize(Subject.Text, TestName.Text);
            Get_Question();
        }
        
        //Создание вариантов заполнения ответов на тест, в соответствии с типом вопроса
#region GetAnswerControls
        //тип "0" радиобатаны
        void GetRadioButtons(List<string> Answer){
            AnsRB.Clear();
            for (int i = 0; i < Answer.Count; i++){
                AnsRB.Add(new RadioButton(){
                    Text = Answer[i],
                    Location = new Point(10, 100 + i * 30),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    Size = new Size(745, 25)
                });
                QuestionGB.Controls.Add(AnsRB[i]);
            }
        }

        //тип "1" чекбоксы
        void GetCheckBoxes(List<string> Answer){
            AnsCB.Clear();
            for (int i = 0; i < Answer.Count; i++){
                AnsCB.Add(new CheckBox(){
                    Text = Answer[i],
                    Location = new Point(10, 100 + i * 30),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    Size = new Size(745, 25)
                });
                QuestionGB.Controls.Add(AnsCB[i]);
            }
        }

        //тип "2" текстбокс
        void GetTextBox()
        {
            AnsTB = new TextBox(){
                Size = new Size(QuestionGB.Size.Width - 10, 25),
                Location = new Point(5, 100),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            QuestionGB.Controls.Add(AnsTB);

        }
#endregion

        //Получение вопроса и ответов
        public void Get_Question(){   
            QuestionGB.Text = "Вопрос № " + (K + 1);
            QuestionLabel.Text = XmlTest.Questions[K].question;
            QuestionGB.Controls.Add(QuestionLabel);
            XmlTest.Questions[K].Type = XmlTest.Questions[K].Type;
            List<string> Answer = XmlTest.Questions[K].Answer;
            switch (XmlTest.Questions[K].Type)
            {
                case 0:{
                    GetRadioButtons(Answer);
                    break;
                }
                case 1:{
                    GetCheckBoxes(Answer);
                    break;
                }
                default:{
                    GetTextBox();
                    break;
                }
            }
        }

        //Собирает список пользовательских ответов
        public List<string> UsAnswer(){
            List<string> UserAnswer = new List<string>();
            switch (XmlTest.Questions[K].Type)
            {
                case 0:
                    {
                        foreach (var box in AnsRB)
                            if (box.Checked)
                            {
                                UserAnswer.Add(box.Text);
                                break;
                            }
                        break;
                    }
                case 1:
                    {
                        foreach (var box in AnsCB)
                            if (box.Checked)
                                UserAnswer.Add(box.Text);
                        break;
                    }
                default:
                    {
                        UserAnswer.Add(AnsTB.Text);
                        break;
                    }
            }
            return UserAnswer;
        }

        //Расчёт баллов за вопрос
        public int CalculationPoint(List<string> UserAnswer)
        {
            int point = 0;
            if (UserAnswer.Count == 0)
            {
                xmlUser.Questions.Add(new Question(XmlTest.Questions[K].question, 0,
                     XmlTest.Questions[K].TrueAnswer));
            }
            else if (XmlTest.Questions[K].Type == 0 || XmlTest.Questions[K].Type == 2)
            {
                foreach (var QA in XmlTest.Questions[K].TrueAnswer)
                {
                    if (QA == UserAnswer[0])
                    {
                        point = XmlTest.Questions[K].Point;
                        xmlUser.Point += point;
                    }
                }
            }
            else {
                int AnsCon = 0;//Совпадения ответов
                foreach (var QTA in XmlTest.Questions[K].TrueAnswer)
                {
                    foreach (var UA in UserAnswer)
                    {
                        if (QTA == UA) AnsCon++;
                    }
                }
                if (AnsCon == XmlTest.Questions[K].TrueAnswer.Count)
                {
                    point = XmlTest.Questions[K].Point;
                    xmlUser.Point += point;
                }
            }
            return point;
        }

        //Считывание ответа пользователя
        private void PushButton_Click(object sender, EventArgs e){
            List<string> UserAnswer = UsAnswer();
            int point = CalculationPoint(UserAnswer);
            if (UserAnswer.Count != 0)
                xmlUser.Questions.Add(new Question(XmlTest.Questions[K].question, point, XmlTest.Questions[K].Type, XmlTest.Questions[K].TrueAnswer, UserAnswer));
            K++;
            if (K == XmlTest.Questions.Count)
            {
                xmlUser.Point = xmlUser.Point;
                if (xmlUser.Point >= XmlTest.Point5)
                    xmlUser.Mark = 5;
                else if (xmlUser.Point >= XmlTest.Point4)
                    xmlUser.Mark = 4;
                else if (xmlUser.Point >= XmlTest.Point3)
                    xmlUser.Mark = 3;
                else
                    xmlUser.Mark = 2;
                xmlUser.Serialize();
                this.Dispose();
                ResultForm.Show();
                return;
            }
            QuestionGB.Controls.Clear();
            Get_Question();
        }


        //Случайное закрытие формы
        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e){
            if (K < XmlTest.Questions.Count && MessageBox.Show(@"Рекомендуется проходить тест до конца, иначе Ваши данные и предыдущие ответы не будут сохранены.\nВы действительно хотите прервать тест?",
                "Закрытие окна теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){ 
                Application.Exit(); 
            }
            else e.Cancel = true;
        }
    }
}

