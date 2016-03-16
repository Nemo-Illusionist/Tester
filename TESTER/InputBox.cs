using System;
using System.Windows.Forms;

namespace TESTER
{
    public partial class InputBox : Form
    {
        public InputBox(){
            InitializeComponent();
        }
        bool t; // Если была нажата кнопка Ok тогда t = true
                // если была нажата кнопка Cancel или в текстовое поле ничего не введено, то t = false
        String temp;

        /// <summary>
        /// Запускает InputBox
        /// </summary>
        /// <param name="IBhead">заголовок формы</param>
        /// <param name="IBlabel">текст, который будет отображен в lable1</param>
        /// <param name="Pass">Если true - то символы в поле ввода заменяются звездочками</param>
        /// <param name="s">значение введенное в текстовое поле, вернется из метода</param>
        /// <returns>false - если нажата кнопка Cancel или поле для ввода пустое</returns>
        public static bool Input(String IBhead, String IBlabel, bool Pass, out String s){
            InputBox IBform = new InputBox(); // создаём форму
            IBform.Text = IBhead; // меняем текст заголовка формы
            IBform.label1.Text = IBlabel; // меняем текст метки
            if (Pass)
                IBform.textBox1.PasswordChar = '*';//заменяет символы на *
            IBform.ShowDialog(); // показываем форму
            s = IBform.temp; // возвращаем введнное значение в s
            return IBform.t;
        }

        // Ok
        private void Ok_Click(object sender, EventArgs e){ 
            temp = this.textBox1.Text;
            t = true;
            this.Close();
        }

        // Cancel
        private void Cancel_Click(object sender, EventArgs e){ 
            t = false;
            this.Close();
        }
    }
}
