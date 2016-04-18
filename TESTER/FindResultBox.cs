using System;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    public partial class FindResultBox : Form
    {
        public FindResultBox()
        {
            InitializeComponent();
        }

        bool t = false;
        string text;

        public static bool Input(out string filename){
            FindResultBox FRB = new FindResultBox(); 
            FRB.ShowDialog();
            filename = FRB.text;
            return FRB.t;
        }

        private void SearchButton_Click(object sender, EventArgs e){
            string[] file = Directory.GetFiles(Environment.CurrentDirectory + "\\UserTest\\");
            foreach (var f in file)
                if (f.Contains(SearchTB.Text + "_")){
                    string s = f.Remove(0, (Environment.CurrentDirectory + "\\UserTest\\").Length);
                    s = s.Remove(s.Length - 4);
                    FoundResultsLV.Items.Add(s);
                }
        }

        private void FoundResultsLV_ItemActivate(object sender, EventArgs e){
            t = true;
            text = FoundResultsLV.SelectedItems[0].Text;
            this.Close();
        }
    }
}
