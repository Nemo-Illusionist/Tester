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
    public partial class DeveloperBox : Form
    {
        public DeveloperBox()
        {
            InitializeComponent();
        }
        String pass;
        int t = 0;

        public static int Input(out String pass)
        {
            DeveloperBox DBform = new DeveloperBox(); // создаём форму
            DBform.ShowDialog(); // показываем форму
            pass = DBform.pass; // возвращаем введнное значение в s
            return DBform.t;
        }

        private void CreateTestButton_Click(object sender, EventArgs e)
        {
            pass = PasswordTB.Text;
            t = 1;
            this.Close();
        }

        private void EditTestButton_Click(object sender, EventArgs e)
        {
            pass = PasswordTB.Text;
            t = 2;
            this.Close();
        }

        private void ChangeEIListButton_Click(object sender, EventArgs e)
        {
            pass = PasswordTB.Text;
            t = 3;
            this.Close();
        }

        private void ClearUserFolderButton_Click(object sender, EventArgs e)
        {
            pass = PasswordTB.Text;
            t = 4;
            this.Close();
        }

        private void DeveloperBox_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
