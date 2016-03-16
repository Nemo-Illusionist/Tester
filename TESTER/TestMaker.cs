using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    public partial class TestMaker : Form{

        public TestMaker(RegisterForm FormRegister){
            InitializeComponent();
            RegisterForm = FormRegister;
        }

        //Инициализация глобальных переменных
#region GlobalVariables
        RegisterForm RegisterForm; //Форма регистрации
        List<TextBox> AnsList = new List<TextBox>(); //список полей для ввода вариантов ответа
        Point Dot = new Point(5, 55); // позиция начального полядля ввода
        List<CheckBox> AnsCheck = new List<CheckBox>(); //список пометок правельных ответов
        public List<string> AnswerList; //список правельных ответов
        public List<string> CorrectAnswerList; //список вариантов ответов
        public List<Question> question; // список вопросов
        int PointMax; //Максимальное кол-во баллов за тест
#endregion

#region Buttons

        //Событие кнопки Далее
        private void GoButton_Click(object sender, EventArgs e){
            if (SubjectCB.Text.Equals("") || SubjectCB.Text.Equals("Добавить...") || TestNameTB.Text.Equals("")){
                MessageBox.Show("Убедитесь в том, что ВСЕ поля заполнены правильно.",
                    "Обнаружена ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                PointCount.Value = decimal.Round(10);
                EnableFields();
                AnsList = new List<TextBox>();
                AnsCheck = new List<CheckBox>();
                question = new List<Question>();
                Dot = new Point(5, 55);
                AddAnswerButton_Click(sender, e);
                AnsType.SelectedIndex = 0;
            }
        }

        //Запись вопроса
        private void AddButton_Click(object sender, EventArgs e){
            if (QuestionTB.Text == ""){
                MessageBox.Show("Кажется, Вы забыли ввести текст вопроса", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!RefreshAnswerFields())
                return;
            PointMax += (int)PointCount.Value;
            /*if (IICheck.Checked){
                if (CorrectAnswerList.Count == AnswerList.Count)
                    question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, CorrectAnswerList));
                else if (CorrectAnswerList.Count == 1)
                    question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, 0, CorrectAnswerList, AnswerList));
                else
                    question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, 1, CorrectAnswerList, AnswerList));
            }
            else*/
            if (AnsType.SelectedIndex != 2)
                question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, AnsType.SelectedIndex, CorrectAnswerList, AnswerList));
            else
                question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, CorrectAnswerList));
            QuestionTB.Text = "";
            AddAnswerButton_Click(null, null);
        }

        //Добовляет поле для ввода дополнительного ответа
        public void AddAnswerButton_Click(object sender, EventArgs e){
            Dot = new Point(5, Dot.Y + 25);
            TextBox TB1 = new TextBox() { Size = new Size(500, 20), Location = Dot };
            Panel.Controls.Add(TB1);
            AnsList.Add(TB1);
            CheckBox CH1 = new CheckBox() { Size = new Size(90, 17), Location = new Point(Dot.X + 520, Dot.Y), Text = "Правильный", };
            CH1.CheckedChanged += new EventHandler(CH1_CheckedChanged);
            CH1_CheckedChanged(sender, e);
            Panel.Controls.Add(CH1);
            AnsCheck.Add(CH1);
        }

        //Удаление поле для ввода дополнительного ответа
        private void RemovAnswerButton_Click(object sender, EventArgs e){
            if (AnsList.Count > 1){
                Dot = new Point(5, Dot.Y - 25);
                Panel.Controls.Remove(AnsList[AnsList.Count - 1]);
                AnsList.Remove(AnsList[AnsList.Count - 1]);
                Panel.Controls.Remove(AnsCheck[AnsCheck.Count - 1]);
                AnsCheck.Remove(AnsCheck[AnsCheck.Count - 1]);
            }
        }

        //Записать тест
        private void CommitTestButton_Click(object sender, EventArgs e)
        {
            AddButton_Click(sender, e);
            if (!SerializeInDocument())
                return;
            MessageBox.Show("Тест успешно сохранен", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableFields();
        }
#endregion

#region SomethingChanged

        //Обновление комбобокса предметов
        private void Combo_Box_Refresh(){
            SubjectCB.Items.Clear();
            string[] science = Directory.GetDirectories(Environment.CurrentDirectory + "\\TEST\\");
            for (int i = 0; i < science.Length; i++){
                SubjectCB.Items.Add(science[i].Remove(0, (Environment.CurrentDirectory + "\\TEST\\").Length));
            }
            SubjectCB.Items.Add("Добавить...");
        }

        //Добовление нового придмета
        private void SubjectCB_SelectedIndexChanged(object sender, EventArgs e){
            if (SubjectCB.Text.Equals("Добавить...")){
                string str;
                if (InputBox.Input("Добавить", "Название предмета", false, out str))
                    if (!Directory.Exists(Environment.CurrentDirectory + "\\TEST\\" + str + "\\")){
                        Directory.CreateDirectory(Environment.CurrentDirectory + "\\TEST\\" + str + "\\");
                        Combo_Box_Refresh();
                    }
                    else
                        MessageBox.Show("Такой предмет уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
#endregion

#region Fields

        //Делаем неактивными неиспользуемые элементы и делаем видимым поле для ввода вопросов
        void EnableFields(){
            AllTime.Enabled =
                GoButton.Enabled = SubjectCB.Enabled = TestNameTB.Enabled =
                 false;
            AddButton.Visible = AddAnswerButton.Visible = Panel.Visible = RemoveAnswerButton.Visible =
                CommitTestButton.Visible = true;
        }

        //Скрываем поле для ввода вопросов
        void DisableFields(){
            foreach (var answer in AnsList){
                Panel.Controls.Remove(answer);
                Panel.Controls.Remove(AnsCheck[AnsList.IndexOf(answer)]);
            }
            AllTime.Enabled =
                GoButton.Enabled = SubjectCB.Enabled = TestNameTB.Enabled =
                true;
            AddButton.Visible = AddAnswerButton.Visible = Panel.Visible = RemoveAnswerButton.Visible =
                CommitTestButton.Visible = false;
            TestNameTB.Text = "";
        }
#endregion

#region LoadOrClosing
        private void TestMaker_Load(object sender, EventArgs e)
        {
            Combo_Box_Refresh();
        }

        private void TestMaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            RegisterForm.SubjectCB_Refresh();
            RegisterForm.Show();
        }
        #endregion

        //Проверка наличия хотя бы одного выбранного ответа
        public bool AnySelected(){
            int a = 0;
            foreach (var check in AnsCheck){
                if (check.Checked)
                    a++;
            }
            if (a == 0){
                MessageBox.Show("Хотя бы один из предложенных Вами вариантов ответов должен быть отмечен как правильный",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //Считывает ответы
        public bool IsVerifiedAnswers(){
            AnswerList = new List<string>();
            CorrectAnswerList = new List<string>();
            bool Kk = true;
            foreach (var answer in AnsList){
                if (answer.Text == "" && Kk){
                    Kk = false;
                    if (MessageBox.Show("Ошибка", "Обнаружен пустой вариант ответа, заполнить?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                        return true;
                }
                if (answer.Text != ""){
                    AnswerList.Add(answer.Text);
                    if (AnsCheck[AnsList.IndexOf(answer)].Checked)
                        CorrectAnswerList.Add(answer.Text);
                }
            }
            return false;
        }

        //Считыватель заполненых полей
        public bool RefreshAnswerFields(){
            if (AnySelected())
                return false;
            if (IsVerifiedAnswers())
                return false;
            foreach (var answer in AnsList){
                Panel.Controls.Remove(answer);
                Panel.Controls.Remove(AnsCheck[AnsList.IndexOf(answer)]);
            }
            AnsList.Clear();
            AnsCheck.Clear();
            Dot = new Point(5, 55);
            return true;
        }

        //Сеарелизует тест в XML документ
        private bool SerializeInDocument(){
            int Point5, Point4, Point3;
            if(MarkBox.Mark(question.Count, PointMax, out Point5, out Point4, out Point3))
                return false;
            XML_TEST XmlTest = new XML_TEST(PointMax, Point3,
                Point4, Point5, (int)AllTime.Value, question);
            XmlTest.Serialize(SubjectCB.Text, TestNameTB.Text);
            return true;
        }

        //Автоматическое определение типа ответов чекбокс
        private void II_CheckedChanged(object sender, EventArgs e){
            if (IICheck.Checked){
                AnsType.Enabled = false;
                CH1_CheckedChanged(sender, e);
            }
            else
                AnsType.Enabled = true;
        }

        //Автоматический оброботчик выброных ответов список чекбоксов
        private void CH1_CheckedChanged(object sender, EventArgs e)
        {
            if (IICheck.Checked){
                byte CheckCount = 0;
                foreach (var box in AnsCheck)
                    if (box.Checked) CheckCount++;
                if (CheckCount == 0)
                    AnsType.SelectedIndex = -1;//Если не выбран ни один вариант ответа, то комбобокс пустой
                else if (CheckCount == AnsCheck.Count)
                    AnsType.SelectedIndex = 2;//Если выделены все варианты, то выводим текстбокс
                else if (CheckCount == 1)
                    AnsType.SelectedIndex = 0;//Вариантов несколько, выделен один - ставим радиобаттон
                else
                    AnsType.SelectedIndex = 1;//В остальных случаях стоит чекбокс    
            }
        }
    }
}