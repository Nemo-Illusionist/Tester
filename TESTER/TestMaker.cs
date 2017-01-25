using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TESTER
{
    public partial class TestMaker : Form{

        public TestMaker(RegisterForm formRegister){
            InitializeComponent();
            _registerForm = formRegister;
        }

#region GlobalVariables
        private readonly RegisterForm _registerForm; //Форма регистрации
        private List<TextBox> _ansList = new List<TextBox>(); //список полей для ввода вариантов ответа
        private Point _dot = new Point(5, 55); // позиция начального полядля ввода
        private List<CheckBox> _ansCheck = new List<CheckBox>(); //список пометок правельных ответов
        private List<string> _answerList; //список правельных ответов
        private List<string> _correctAnswerList; //список вариантов ответов
        private List<Question> _question; // список вопросов
        private int _pointMax; //Максимальное кол-во баллов за тест
#endregion

#region ButtonsClick

        //Событие кнопки Далее
        private void GoButton_Click(object sender, EventArgs e){
            if (SubjectCB.Text.Equals("") || SubjectCB.Text.Equals("Добавить...") || TestNameTB.Text.Equals("")){
                MessageBox.Show("Убедитесь в том, что ВСЕ поля заполнены правильно.",
                    "Обнаружена ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                PointCount.Value = decimal.Round(10);
                EnableFields();
                _ansList = new List<TextBox>();
                _ansCheck = new List<CheckBox>();
                _question = new List<Question>();
                _dot = new Point(5, 55);
                AddAnswerButton.PerformClick();
                AnsType.SelectedIndex = 0;
            }
        }

        //Запись вопроса
        private void AddButton_Click(object sender, EventArgs e){
            AddAnswer();
        }

        //Добовляет поле для ввода дополнительного ответа
        public void AddAnswerButton_Click(object sender, EventArgs e){
            _dot = new Point(5, _dot.Y + 25);
            var tb1 = new TextBox() { Size = new Size(500, 20), Location = _dot };
            label3.Text = "Вопрос №" + (_question.Count + 1);
            Panel.Controls.Add(tb1);
            _ansList.Add(tb1);
            var ch1 = new CheckBox() { Size = new Size(90, 17), Location = new Point(_dot.X + 520, _dot.Y), Text = "Правильный", };
            ch1.CheckedChanged += CH1_CheckedChanged;
            CH1_CheckedChanged(sender, e);
            Panel.Controls.Add(ch1);
            _ansCheck.Add(ch1);
        }

        //Удаление поле для ввода дополнительного ответа
        private void RemovAnswerButton_Click(object sender, EventArgs e){
            if (_ansList.Count > 1){
                _dot = new Point(5, _dot.Y - 25);
                Panel.Controls.Remove(_ansList[_ansList.Count - 1]);
                _ansList.Remove(_ansList[_ansList.Count - 1]);
                Panel.Controls.Remove(_ansCheck[_ansCheck.Count - 1]);
                _ansCheck.Remove(_ansCheck[_ansCheck.Count - 1]);
            }
        }

        //Записать тест
        private void CommitTestButton_Click(object sender, EventArgs e){
            if (!AddAnswer() || !SerializeInDocument())
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
        private void EnableFields(){
            AllTime.Enabled =
                GoButton.Enabled = SubjectCB.Enabled = TestNameTB.Enabled =
                 false;
            AddButton.Visible = AddAnswerButton.Visible = Panel.Visible = RemoveAnswerButton.Visible =
                CommitTestButton.Visible = true;
        }

        //Скрываем поле для ввода вопросов
        private void DisableFields(){
            foreach (var answer in _ansList){
                Panel.Controls.Remove(answer);
                Panel.Controls.Remove(_ansCheck[_ansList.IndexOf(answer)]);
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
            Hide();
            _registerForm.SubjectCB_Refresh();
            _registerForm.Show();
        }
#endregion

        //Записать вопрос
        public bool AddAnswer(){
            if (QuestionTB.Text == ""){
                MessageBox.Show("Кажется, Вы забыли ввести текст вопроса", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!RefreshAnswerFields())
                return false;
            _pointMax += (int)PointCount.Value;
            if (AnsType.SelectedIndex != 2)
                _question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, AnsType.SelectedIndex, _correctAnswerList, _answerList));
            else
                _question.Add(new Question(QuestionTB.Text, (int)PointCount.Value, _correctAnswerList));
            QuestionTB.Text = "";
            AddAnswerButton.PerformClick();
            return true;
        }

        //Проверка наличия хотя бы одного выбранного ответа
        public bool AnySelected(){
            int a = 0;
            foreach (var check in _ansCheck){
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
            _answerList = new List<string>();
            _correctAnswerList = new List<string>();
            var kk = true;
            foreach (var answer in _ansList){
                if (answer.Text == "" && kk){
                    kk = false;
                    if (MessageBox.Show("Обнаружен пустой вариант ответа. Записать вопрос все равно?", "Ошибка", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                        return true;
                }
                if (answer.Text != ""){
                    _answerList.Add(answer.Text);
                    if (_ansCheck[_ansList.IndexOf(answer)].Checked)
                        _correctAnswerList.Add(answer.Text);
                }
            }
            return false;
        }

        //Считыватель заполненых полей
        public bool RefreshAnswerFields(){
            if (AnySelected() || IsVerifiedAnswers())
                return false;
            foreach (var answer in _ansList){
                Panel.Controls.Remove(answer);
                Panel.Controls.Remove(_ansCheck[_ansList.IndexOf(answer)]);
            }
            _ansList.Clear();
            _ansCheck.Clear();
            _dot = new Point(5, 55);
            return true;
        }

        //Сеарелизует тест в XML документ
        private bool SerializeInDocument(){
            int point5, point4, point3;
            if(!MarkBox.Mark(_question.Count, _pointMax, out point5, out point4, out point3))
                return false;
            var xmlTest = new XML_TEST(_pointMax, point3,
                point4, point5, (int)AllTime.Value, _question);
            xmlTest.Serialize(SubjectCB.Text, TestNameTB.Text);
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
                var checkCount = _ansCheck.Count(box => box.Checked);
                if (checkCount == 0)
                    AnsType.SelectedIndex = -1;//Если не выбран ни один вариант ответа, то комбобокс пустой
                else if (checkCount == _ansCheck.Count)
                    AnsType.SelectedIndex = 2;//Если выделены все варианты, то выводим текстбокс
                else if (checkCount == 1)
                    AnsType.SelectedIndex = 0;//Вариантов несколько, выделен один - ставим радиобаттон
                else
                    AnsType.SelectedIndex = 1;//В остальных случаях стоит чекбокс    
            }
        }
    }
}