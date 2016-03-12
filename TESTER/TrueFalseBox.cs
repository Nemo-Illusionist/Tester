using System;
using System.Windows.Forms;

namespace TESTER
{
    public partial class TrueFalseBox : Form
    {
        public TrueFalseBox(){
            InitializeComponent();
        }
        bool t; // Если была нажата кнопка Ok тогда t = true
                // если была нажата кнопка Cancel или в текстовое поле ничего не введено, то t = false

        /// <param name="IBhead">заголовок формы</param>
        /// <param name="IBlabel">текст, который будет отображен в lable1</param>
        public static bool TrueFalse(String IBhead, String IBlabel){
            TrueFalseBox TFBform = new TrueFalseBox(); // создаём форму
            TFBform.Text = IBhead; // меняем текст заголовка формы
            TFBform.label1.Text = IBlabel; // меняем текст метки
            TFBform.ShowDialog(); // показываем форму
            return TFBform.t;
        }

        // Ok
        private void Ok_Click(object sender, EventArgs e){
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
