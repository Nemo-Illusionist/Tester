using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TESTER
{
    public partial class QuestionForm : Form
    {
        public QuestionForm(RegisterForm Form1)
        {
            InitializeComponent();
            RegisterForm = Form1;
            ResultForm = new ResultForm(this);
        }

        //Инициализация глобальных переменных
#region GlobalVariables
        RegisterForm RegisterForm;
        ResultForm ResultForm;
        TextBox AnsTB;
        Label QuestionLabel = new Label(){
            Size = new Size(750, 80),
            Location = new Point(5, 15),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            Font = new Font("Tahoma", 12.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)))
        };
        List<RadioButton> AnsRB = new List<RadioButton>();
        List<CheckBox> AnsCB = new List<CheckBox>();
        List<Question> question;
        List<string> AnswersList = new List<string>();
        string CurrentAnswer;
        int K = 0;
        int type;
        public object sender { get; set; }
        public EventArgs e { get; set; }
#endregion

        //Загрузка формы
        private void QuestionForm_Load(object sender, EventArgs e){
            this.WindowState = FormWindowState.Maximized;
            FIO.Text = RegisterForm.FIO_TextBox.Text;
            EI.Text = RegisterForm.EI_CB.Text;
            Subject.Text = RegisterForm.Subject_CB.Text;
            TestName.Text = RegisterForm.Test_CB.Text;
            XML_TEST XmlTest = new XML_TEST();
            XmlTest.DeSerialize(Subject.Text, TestName.Text);
            question = XmlTest.Questions;
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
            QuestionLabel.Text = question[K].question;
            QuestionGB.Controls.Add(QuestionLabel);
            type = question[K].Type;
            List<string> Answer = question[K].Answer;
            switch (type){
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
            K++;
        }


//НАДО ДОРАБОТАТЬ...Считывание ответа пользователя
        private void PushButton_Click(object sender, EventArgs e){
            switch (type){
                case 0:{
                    foreach (var box in AnsRB){
                        if (box.Checked) { 
                            CurrentAnswer += box.Text; 
                            break; 
                        }
                    }
                    AnswersList.Add(CurrentAnswer);
                    break;
                }
                case 1:{
                    foreach (var box in AnsCB){
                        if (box.Checked){
                            CurrentAnswer += box.Text;
                                if (box != AnsCB[AnsCB.Count - 1]) CurrentAnswer += ", ";
                        }
                    }
                    AnswersList.Add(CurrentAnswer);
                    break;
                }
                default:{
                    AnswersList.Add(AnsTB.Text);
                    break;
                }
                /*default:{
//......................ДОРАБОТАТЬ
                        MessageBox.Show("НЕХУЙ БЫЛО ЛАЗИТЬ В XML", "Данная ошибка еще не обработана");
                        break;
                    }*/
            }
            CurrentAnswer = "";
            if (K == question.Count){
                this.Dispose();
                ResultForm.Show();
                foreach (var answer in AnswersList){
                    ListViewItem Item = new ListViewItem();
                    Item.Text = (ResultForm.AnswersView.Items.Count + 1).ToString();
                    Item.SubItems.Add(answer);
                    Item.SubItems.Add("правильный ответ");
                    ResultForm.AnswersView.Items.Add(Item);
                }
                return;
            }
            QuestionGB.Controls.Clear();
            Get_Question();
        }

        //Случайное закрытие формы
        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e){
            if (K < question.Count && MessageBox.Show(@"Рекомендуется проходить тест до конца, иначе Ваши данные и предыдущие ответы не будут сохранены.\nВы действительно хотите прервать тест?",
                "Закрытие окна теста", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){ 
                Application.Exit(); 
            }
            else e.Cancel = true;
        }
    }
}

