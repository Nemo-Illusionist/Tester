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
    public partial class MarkBox : Form{
        public MarkBox(){
            InitializeComponent();
        }
        Int32 P5, P4, P3;
        Boolean t;


        /// <param name="QuantityQuestion">кол-во вопросов</param>
        /// <param name="MaxPoint">максимально баллов</param>
        /// <param name="Point5">баллов на 5</param>
        /// <param name="Point4">баллов на 4</param>
        /// <param name="Point3">баллов на 3</param>
        public static Boolean Mark(int QuantityQuestion, int MaxPoint, out Int32 Point5, out Int32 Point4, out Int32 Point3){
            MarkBox Markform = new MarkBox();
            Markform.QuantityQuestion.Text = "" + QuantityQuestion;
            Markform.Maxpoint.Text = "" + MaxPoint;
            Markform.t = false;
            Markform.Point5.Maximum = MaxPoint;
            Markform.Point4.Maximum = MaxPoint;
            Markform.Point3.Maximum = MaxPoint;
            Markform.Point5.Value = (decimal)Math.Round(MaxPoint * 0.9, 0);
            Markform.Point4.Value = (decimal)Math.Round(MaxPoint * 0.75, 0);
            Markform.Point3.Value = (decimal)Math.Round(MaxPoint * 0.60, 0);
            Markform.ShowDialog();
            Point5 = Markform.P5;
            Point4 = Markform.P4;
            Point3 = Markform.P3;
            return Markform.t;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            P5 = (int)this.Point5.Value;
            P4 = (int)this.Point4.Value;
            P3 = (int)this.Point3.Value;
            t = true;
            this.Close();
        }
    }
}
