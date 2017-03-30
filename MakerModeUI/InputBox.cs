using System;
using System.Windows.Forms;

namespace MakerModeUI
{
    public partial class InputBox : Form
    {
        public InputBox(){
            InitializeComponent();
        }
        private bool _t; 
        private string _text;

        /// <summary>
        /// Запускает InputBox
        /// </summary>
        /// <param name="head">заголовок формы</param>
        /// <param name="label">смысловой текст ввода1</param>
        /// <param name="text">значение введенное в текстовое поле</param>
        /// <param name="pass">Если true - то символы в поле ввода заменяются звездочками</param>
        /// <returns>false - если нажата кнопка Cancel или поле для ввода пустое</returns>
        public static bool Input(string head, string label, ref string text, bool pass = false)
        {
            var form = new InputBox
            {
                _t = false,
                Text = head,
                label1 = {Text = label},
                textBox1 = {Text = text}
            };
            if (pass)
                form.textBox1.PasswordChar = '*';
            form.ShowDialog(); 
            text = form._text; 
            return form._t;
        }
        
        private void Ok_Click(object sender, EventArgs e){ 
            _text = textBox1.Text;
            _t = true;
            Close();
        }
        
        private void Cancel_Click(object sender, EventArgs e){ 
            Close();
        }
    }
}
