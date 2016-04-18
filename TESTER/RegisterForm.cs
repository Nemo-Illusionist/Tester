using System;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    public partial class RegisterForm : Form
    {

        public RegisterForm(){
            InitializeComponent();
            QuestionForm = new QuestionForm();
        }

        QuestionForm QuestionForm;
        TestMaker TestMaker;

        //Обновление списка предметов
        public void SubjectCB_Refresh(){
            Subject_CB.Items.Clear();
            string[] science = Directory.GetDirectories(Environment.CurrentDirectory + "\\TEST\\");
            for (int i = 0; i < science.Length; i++){
                Subject_CB.Items.Add(science[i].Remove(0, (Environment.CurrentDirectory + "\\TEST\\").Length));
            }
        }

        //Обновление списка тестов при выборе предмета
        private void Subject_CB_SelectedIndexChanged(object sender, EventArgs e){
            Test_CB.Items.Clear();
            string[] NameTest = Directory.GetFiles(Environment.CurrentDirectory + "\\TEST\\" + Subject_CB.Text + "\\");
            if (NameTest.Length != 0){
                for (int i = 0; i < NameTest.Length; i++){
                    NameTest[i] = NameTest[i].Remove(0, (Environment.CurrentDirectory + "\\TEST\\" + Subject_CB.Text + "\\").Length);
                    if (NameTest[i].Contains(".xml"))
                        Test_CB.Items.Add(NameTest[i].Remove(NameTest[i].Length - 4));
                }
            }
            else{
                Test_CB.Items.Add("Для данного предмета тесты отсутствуют");
            }
        }

        //Запуск теста
        private void StartButton_Click(object sender, EventArgs e){
            if (FIO_TextBox.Text == ""){
                MessageBox.Show("Нужно обязательно ввести свои настоящие ФИО, ибо от наличия ответов от Вашего имени зависит Ваша оценка", "Обнаружена ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EI_CB.SelectedIndex < 0 || Subject_CB.SelectedIndex < 0 || Test_CB.SelectedIndex < 0 || ID_TextBox.TextLength<1){
                MessageBox.Show("Вы заполнили не все поля.", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            QuestionForm.xmlUser = new XML_USER(long.Parse(ID_TextBox.Text), FIO_TextBox.Text, EI_CB.Text, Subject_CB.Text,
                Test_CB.Text);
            QuestionForm.Text = "["+ID_TextBox.Text+"] "+Test_CB.Text;
            QuestionForm.Show();
        }

        //Режим Бога 
        private void GodModeTSMI_Click(object sender, EventArgs e){
            string s;
            int t = DeveloperBox.Input(out s);
            if (t != 0)
            {
                if (s.Equals("God"))
                {
                    switch (t) {
                        case 1:{
                                TestMaker = new TestMaker(this);
                                TestMaker.Show();
                                this.Hide();
                                break;
                            }
                        case 2: { break; }
                        case 3:{
                            if (EIEditor.Input())
                            {
                                EI_CB.Items.Clear();
                                string[] EducationalInstitutions = File.ReadAllLines(Environment.CurrentDirectory + "\\EI.txt");
                                EI_CB.Items.AddRange(EducationalInstitutions);
                            }
                                
                                break;
                            }
                        case 4: {
                            if (MessageBox.Show("Вы действительно хотите очистить папку пользовательских тестов?\n"+
                                "Если вы не сохранили результаты в архив, нажмите \"Нет\", сохраните тесты из папки, и после этого вернитесь сюда",
                                "Намечается очистка ученических результатов", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes){
                                    string[] Files = Directory.GetFiles(Environment.CurrentDirectory + "\\UserTest\\");
                                    foreach(string file in Files)
                                    File.Delete(file);
                                    }
                                    break; 
                                }
                    }
                }
                else
                    MessageBox.Show("Неверный пароль");
            }
            /*TestMaker = new TestMaker(this);
            TestMaker.Show();
            this.Hide();*/
        }

        //Загрузка формы
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            FIO_TextBox.Focus();
            SubjectCB_Refresh();
            /*try
            {*/
            string[] EducationalInstitutions = File.ReadAllLines(Environment.CurrentDirectory + "\\EI.txt");
                EI_CB.Items.AddRange(EducationalInstitutions);
            /*}
            catch (Exception)
            {
                MessageBox.Show("Список учебных заведений не был загружен.", "Не найден файл EI.txt");
                EI_CB.Items.AddRange(new string[]{
                    "ГОУ \"ВИМО ПМР им. А.И. Лебедя\"",
                    "ГОУ \"ПГУ им. Т.Г. Шевченко\"",
                    "ГОУ \"ТМУ\"",
                    "ГОУ \"ТЮИ МВД ПМР\"",
                    "МОУ \"Бендерская гимназия №2\"",
                    "МОУ \"Бендерский теоретический лицей №1\""
            });
            }*/
        }

        //Закрытие формы
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e){
            Application.Exit();
        }

        //Проверка ID на случай ввода иных символов, кроме цифры
        private void ID_TextBox_KeyPress(object sender, KeyPressEventArgs e){
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) 
                e.Handled = true;
        }

        //Справка
        private void ShowHelpTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро появится", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //О программе
        private void AboutTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро появится", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Посмотреть свои результаты
        private void ViewResultsTSMI_Click(object sender, EventArgs e)
        {

        }

        //Проверить апдейты тестов с сервера
        private void CheckUpdatesTSMI_Click(object sender, EventArgs e)
        {

        }
        //Меню "Закрыть"
        private void ExitTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}