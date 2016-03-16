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
        public ResultForm(){
            InitializeComponent();
        }

        XML_USER user;

        public void FillInformation(){
            InfoLabel.Text = user.FIO + "\n" + user.ID + "\n" + user.EI + "\n" + user.Science + "\n" + user.Theme;
            YourMarkLabel.Text = user.Mark.ToString();
            YourPointsLabel.Text = user.Point.ToString();
            switch (user.Mark){
                case 2:
                    TrololoPB.BackgroundImage = Properties.Resources.Point2;
                    break;
                case 3:
                    TrololoPB.BackgroundImage = Properties.Resources.Point3;
                    break;
                case 4:
                    TrololoPB.BackgroundImage = Properties.Resources.Point4;
                    break;
                case 5:
                    TrololoPB.BackgroundImage = Properties.Resources.Point5;
                    break;
            }
        }

        public void FillListView(){
            int k = 1;
            foreach (var qq in user.Questions){
                ListViewItem LVI = new ListViewItem(k.ToString());
                LVI.SubItems.Add(qq.Point.ToString());
                if (qq.Answer != null)
                    LVI.SubItems.Add(string.Join(", ", qq.Answer));
                else
                    LVI.SubItems.Add("-");
                LVI.SubItems.Add(string.Join(", ", qq.TrueAnswer));
                AnswersView.Items.Add(LVI);
                k++;
            }
        }

        public void MakeGraphic()
        {
            Diagram.Series[0].Points[0].YValues[0] = user.Point;
            Diagram.Series[0].Points[1].YValues[0] = user.MaxPoint - user.Point;
        }

        public static void ShowForm(XML_USER user){
            ResultForm resultForm = new ResultForm();
            resultForm.user = user;
            resultForm.FillInformation();
            resultForm.FillListView();
            resultForm.MakeGraphic();
            resultForm.ShowDialog();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e){
            this.Hide();
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }

        private void ResultForm_Load(object sender, EventArgs e){

        }


    }
}
