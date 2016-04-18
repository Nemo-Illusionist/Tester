using System;
using System.Windows.Forms;

namespace TESTER
{
    public partial class MarkBox : Form{
        public MarkBox(){
            InitializeComponent();
        }
        Int32 P5, P4, P3;
        Boolean t;
        int MP = 100;

        private void Points_ValueChanged(object sender, EventArgs e){
            Percent5.Value = (decimal)Math.Round(Point5.Value / MP * 100, 0);
            Percent4.Value = (decimal)Math.Round(Point4.Value / MP * 100, 0);
            Percent3.Value = (decimal)Math.Round(Point3.Value / MP * 100, 0);
            Percent4.Maximum = Percent5.Value;
            Percent3.Maximum = Percent4.Value;
        }

        private void Percents_ValueChanged(object sender, EventArgs e){
            Point5.Value = (decimal)Math.Round(MP * Percent5.Value / 100, 0);
            Point4.Value = (decimal)Math.Round(MP * Percent4.Value / 100, 0);
            Point3.Value = (decimal)Math.Round(MP * Percent3.Value / 100, 0);
            Point5.Maximum = MP;
            Point4.Maximum = Point5.Value;
            Point3.Maximum = Point4.Value;
        }

        /// <summary>
        /// Запускает форму системы оценок
        /// </summary>
        /// <param name="QuantityQuestion">кол-во вопросов</param>
        /// <param name="MaxPoint">максимально баллов</param>
        /// <param name="Point5">баллов на 5</param>
        /// <param name="Point4">баллов на 4</param>
        /// <param name="Point3">баллов на 3</param>
        /// <returns>true - если нажата кнопка сохранить</returns>
        public static Boolean Mark(int QuantityQuestion, int MaxPoint, out Int32 Point5, out Int32 Point4, out Int32 Point3){
            MarkBox Markform = new MarkBox();
            Markform.MP = MaxPoint;
            Markform.QuantityQuestion.Text = "" + QuantityQuestion;
            Markform.Maxpoint.Text = "" + MaxPoint;
            Markform.t = false;
            Markform.Point5.Value = (decimal)Math.Round(MaxPoint * 0.9, 0);
            Markform.Point4.Value = (decimal)Math.Round(MaxPoint * 0.75, 0);
            Markform.Point3.Value = (decimal)Math.Round(MaxPoint * 0.6, 0);
            Markform.ShowDialog();
            Point5 = Markform.P5;
            Point4 = Markform.P4;
            Point3 = Markform.P3;
            return Markform.t;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            P5 = (int)Point5.Value;
            P4 = (int)Point4.Value;
            P3 = (int)Point3.Value;
            t = true;
            this.Close();
        }
    }
}
