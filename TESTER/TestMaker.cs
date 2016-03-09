using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    public partial class TestMaker : Form
    {
        public TestMaker(RegisterForm FormRegister){
            InitializeComponent();
            RegisterForm = FormRegister;
        }

        RegisterForm RegisterForm;
        List<TextBox> AnsList = new List<TextBox>();
        List<CheckBox> AnsCheck = new List<CheckBox>();
        Point Dot = new Point(5, 55);
        public List<string> AnswerList;
        public List<string> CorrectAnswerList;
        Int16 CurQuest = 0;
        public List<Question> question;
        Boolean k = false;

#region Buttons
        private void GoButton_Click(object sender, EventArgs e){
            if (SubjectCB.Text.Equals("") || SubjectCB.Text.Equals("Добавить...") || TestNameTB.Text.Equals("") || (int)PointMax.Value == 0 ||
                (int)Point3.Value == 0 || (int)Point4.Value == 0 || (int)Point5.Value == 0){
                MessageBox.Show("Убедитесь в том, что ВСЕ поля заполнены правильно.",
                    "Обнаружена ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                PointCount.Value = decimal.Round(PointMax.Value / QuestCount.Value);
                EnableFields();
                AnsList = new List<TextBox>();
                AnsCheck = new List<CheckBox>();
                question = new List<Question>();
                RefreshAnswerFields();
                AnsType.SelectedIndex = 0;
            }
        }
        
        private void AddButton_Click(object sender, EventArgs e){
            if (QuestionTB.Text == ""){
                MessageBox.Show("Кажется, Вы забыли ввести текст вопроса", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var item in AnswerList){
                if (item == ""){ 
                    MessageBox.Show("Обнаружен пустой вариант ответа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            RefreshAnswerFields();
            if (k == false)
                return;
            if (AnsType.SelectedIndex != 2){
                question.Add(new Question(QuestionTB.Text, (int)PointCount.Value,
                (int)AnsType.SelectedIndex, CorrectAnswerList, AnswerList));
            }
            else{
                question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, CorrectAnswerList));
            }
            QuestionTB.Text = "";
            CurQuest++;
            if (CurQuest > (int)QuestCount.Value - 1){
                SerializeInDocument();
                MessageBox.Show("Готово!");
                DisableFields();
                CurQuest = 0;
            }
        }

        public void AddAnswerButton_Click(object sender, EventArgs e){
            Dot = new Point(5, Dot.Y + 25);
            TextBox TB1 = new TextBox() { Size = new Size(500, 20), Location = Dot };
            Panel.Controls.Add(TB1);
            AnsList.Add(TB1);
            CheckBox CH1 = new CheckBox() { Size = new Size(90, 17), Location = new Point(Dot.X + 520, Dot.Y), Text = "Правильный" };
            Panel.Controls.Add(CH1);
            AnsCheck.Add(CH1);
        }
#endregion

#region SomethingChanged
        private void Combo_Box_Refresh(){
            SubjectCB.Items.Clear();
            string[] science = Directory.GetDirectories(Environment.CurrentDirectory + "\\TEST\\");
            for (int i = 0; i < science.Length; i++){
                SubjectCB.Items.Add(science[i].Remove(0, (Environment.CurrentDirectory + "\\TEST\\").Length));
            }
            SubjectCB.Items.Add("Добавить...");
        }

        private void SubjectCB_SelectedIndexChanged(object sender, EventArgs e){
            if (SubjectCB.Text.Equals("Добавить...")){
                string str;
                if (InputBox.Input("Добавить", "Название предмета", out str))
                    if (Directory.Exists(Environment.CurrentDirectory + "\\TEST\\" + str + "\\") == false){
                        Directory.CreateDirectory(Environment.CurrentDirectory + "\\TEST\\" + str + "\\");
                        Combo_Box_Refresh();
                    }
                    else
                        MessageBox.Show("Такой предмет уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void PointMax_ValueChanged(object sender, EventArgs e){
            Point5.Value = (decimal)Math.Round((int)PointMax.Value * 0.9, 0);
            Point4.Value = (decimal)Math.Round((int)PointMax.Value * 0.75, 0);
            Point3.Value = (decimal)Math.Round((int)PointMax.Value * 0.60, 0);
        }
#endregion

#region Fields
        void EnableFields(){
            QuestCount.Enabled = AllTime.Enabled = PointMax.Enabled =
                Point5.Enabled = Point4.Enabled = Point3.Enabled =
                GoButton.Enabled = SubjectCB.Enabled = TestNameTB.Enabled =
                false;
            AddButton.Visible = AddAnswerButton.Visible = Panel.Visible =
                true;
        }
        void DisableFields(){
            foreach (var answer in AnsList){
                Panel.Controls.Remove(answer);
                Panel.Controls.Remove(AnsCheck[AnsList.IndexOf(answer)]);
            }
            QuestCount.Enabled = AllTime.Enabled = PointMax.Enabled =
                Point5.Enabled = Point4.Enabled = Point3.Enabled =
                GoButton.Enabled = SubjectCB.Enabled = TestNameTB.Enabled =
                true;
            AddButton.Visible = AddAnswerButton.Visible = Panel.Visible =
                false;
            TestNameTB.Text = "";
        }
#endregion

#region LoadOrClosing
        private void TestMaker_Load(object sender, EventArgs e){
            Combo_Box_Refresh();
        }

        private void TestMaker_FormClosing(object sender, FormClosingEventArgs e){
            this.Hide();
            RegisterForm.SubjectCB_Refresh();
            RegisterForm.Show();
        }
#endregion

        public void RefreshAnswerFields(){
            AnswerList = new List<string>();
            CorrectAnswerList = new List<string>();
            foreach (var answer in AnsList){
                AnswerList.Add(answer.Text);
                if (AnsCheck[AnsList.IndexOf(answer)].Checked){ 
                    CorrectAnswerList.Add(answer.Text); 
                }
            }
            if (CorrectAnswerList.Count == 0 && AnsList.Count != 0){
                MessageBox.Show("Хотя бы один из предложенных Вами вариантов ответов должен быть отмечен как правильный",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                k = false;
                return;
            }
            foreach (var answer in AnsList){
                Panel.Controls.Remove(answer);
                Panel.Controls.Remove(AnsCheck[AnsList.IndexOf(answer)]);
            }
            AnsList.Clear();
            AnsCheck.Clear();
            Dot = new Point(5, 55);
            AddAnswerButton_Click(null, null);
            k = true;
        }

        private void SerializeInDocument(){
            XML_TEST XmlTest = new XML_TEST((int)QuestCount.Value, (int)PointMax.Value, (int)Point3.Value, 
                (int)Point4.Value, (int)Point5.Value, (int)AllTime.Value, question);
            XmlTest.Serialize(SubjectCB.Text, TestNameTB.Text);
        }
    }
}
