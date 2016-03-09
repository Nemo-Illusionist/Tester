using System;
using System.Windows.Forms;

namespace TESTER
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }
        bool t; // Если была нажата кнопка Ok тогда t = true
                // если была нажата кнопка Cancel или в текстовое поле ничего не введено, то t = false
        String temp;

        /// <param name="IBhead">заголовок формы</param>
        /// <param name="IBlabel">текст, который будет отображен в lable1</param>
        /// <param name="s">значение введенное в текстовое поле, вернется из метода</param>
        public static bool Input(String IBhead, String IBlabel, out String s)
        {
            InputBox IBform = new InputBox(); // создаём форму
            IBform.Text = IBhead; // меняем текст заголовка формы
            IBform.label1.Text = IBlabel; // меняем текст метки
            IBform.ShowDialog(); // показываем форму
            s = IBform.temp; // возвращаем введнное значение в s
            return IBform.t;
        }

        /// <param name="IBhead">заголовок формы</param>
        /// <param name="IBlabel">текст, который будет отображен в lable1</param>
        /// <param name="s">значение введенное в текстовое поле, вернется из метода</param>
        public static bool InputPassword(String IBhead, String IBlabel, out String s)
        {
            InputBox IBform = new InputBox(); // создаём форму
            IBform.Text = IBhead; // меняем текст заголовка формы
            IBform.label1.Text = IBlabel; // меняем текст метки
            IBform.textBox1.PasswordChar = '*';
            IBform.ShowDialog(); // показываем форму
            s = IBform.temp; // возвращаем введнное значение в s
            return IBform.t;
        }


        private void Ok_Click(object sender, EventArgs e) // Ok
        {
            temp = this.textBox1.Text;
            t = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e) // Cancel
        {
            t = false;
            this.Close();
        }
    }
}
