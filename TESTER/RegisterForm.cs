﻿using System;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
            QuestionForm = new QuestionForm(this);
        }

        QuestionForm QuestionForm;
        TestMaker TestMaker;

        //обновление списка предметов
        public void SubjectCB_Refresh()
        {
            Subject_CB.Items.Clear();
            string[] science = Directory.GetDirectories(Environment.CurrentDirectory + "\\TEST\\");
            for (int i = 0; i < science.Length; i++)
            {
                Subject_CB.Items.Add(science[i].Remove(0, (Environment.CurrentDirectory + "\\TEST\\").Length));
            }
        }

        //обновление списка тестов в выброном предмете
        private void Subject_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Test_CB.Items.Clear();
            string[] NameTest = Directory.GetFiles(Environment.CurrentDirectory + "\\TEST\\" + Subject_CB.Text + "\\");
            if (NameTest.Length != 0)
            {
                for (int i = 0; i < NameTest.Length; i++)
                {
                    NameTest[i] = NameTest[i].Remove(0, (Environment.CurrentDirectory + "\\TEST\\" + Subject_CB.Text + "\\").Length);
                    if (NameTest[i].Contains(".xml"))
                        Test_CB.Items.Add(NameTest[i].Remove(NameTest[i].Length - 4));
                }
            }
            else
            {
                Test_CB.Items.Add("Для данного предмета тесты отсутствуют");
            }
        }

        //запуск теста
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (FIO_TextBox.Text == "")
            {
                MessageBox.Show("Нужно обязательно ввести свои настоящие ФИО, ибо от наличия ответов от Вашего имени зависит Ваша оценка", "Обнаружена ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EI_CB.SelectedIndex < 0 || Subject_CB.SelectedIndex < 0 || Test_CB.SelectedIndex < 0)
            {
                MessageBox.Show("Вы заполнили не все поля.", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            QuestionForm.Show();
        }

        //режим бога
        private void God_mode_Click(object sender, EventArgs e)
        {
            string s;
            if (InputBox.InputPassword("Режим бога", "Введите пожалуйста пароль(God)", out s))
            {
                if (s.Equals("God"))
                {
                    TestMaker = new TestMaker(this);
                    TestMaker.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Неверный пароль");
            }
        }

        //загрузка формы
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            FIO_TextBox.Focus();
            SubjectCB_Refresh();
        }

        //закрытие формы
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}