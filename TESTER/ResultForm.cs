using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TESTER
{
    public partial class ResultForm : Form
    {
        public ResultForm(QuestionForm Que1)
        {
            InitializeComponent();
            QuestionForm = Que1;
        }

        QuestionForm QuestionForm;

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
