using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TESTER
{
    public partial class EIEditor : Form
    {
        public EIEditor()
        {
            InitializeComponent();
        }
        bool t;

        public static bool Input() {
            EIEditor EIE = new EIEditor(); // создаём форму
            EIE.EIListTB.Clear();
            string[] geis = File.ReadAllLines(Environment.CurrentDirectory + "\\EI.txt");
            foreach (string s in geis)
                EIE.EIListTB.Text += s + "\r\n";
            EIE.ShowDialog(); // показываем форму
            return EIE.t;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\EI.txt", EIListTB.Text);
            t = true;
                this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            t = false;
            this.Close();
        }
    }
}
