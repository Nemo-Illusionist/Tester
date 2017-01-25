using System;
using System.Windows.Forms;

namespace MakerModeUI
{
    public partial class MarkBox : Form
    {
        private int _p5, _p4, _p3;
        private bool _t;
        private int _mp = 100;

        public MarkBox()
        {
            InitializeComponent();
        }

        private void Points_ValueChanged(object sender, EventArgs e)
        {
            Percent5.Value = Math.Round(Point5.Value / _mp * 100, 0);
            Percent4.Value = Math.Round(Point4.Value / _mp * 100, 0);
            Percent3.Value = Math.Round(Point3.Value / _mp * 100, 0);
            Percent4.Maximum = Percent5.Value;
            Percent3.Maximum = Percent4.Value;
        }

        private void Percents_ValueChanged(object sender, EventArgs e)
        {
            Point5.Value = Math.Round(_mp * Percent5.Value / 100, 0);
            Point4.Value = Math.Round(_mp * Percent4.Value / 100, 0);
            Point3.Value = Math.Round(_mp * Percent3.Value / 100, 0);
            Point5.Maximum = _mp;
            Point4.Maximum = Point5.Value;
            Point3.Maximum = Point4.Value;
        }

        /// <summary>
        /// Запускает форму системы оценок
        /// </summary>
        /// <param name="quantityQuestion">Кол-во вопросов</param>
        /// <param name="maxPoint">Максимально баллов</param>
        /// <param name="point5">Баллов на 5</param>
        /// <param name="point4">Баллов на 4</param>
        /// <param name="point3">Баллов на 3</param>
        /// <returns>true - если нажата кнопка сохранить</returns>
        public static bool Mark(int quantityQuestion, int maxPoint, out int point5, out int point4, out int point3)
        {
            var markform = new MarkBox
            {
                _mp = maxPoint,
                _t = false,
                QuantityQuestion = {Text = quantityQuestion.ToString()},
                MaxPoint = {Text = maxPoint.ToString()},
                Point5 = {Value = (decimal) Math.Round(maxPoint*0.9, 0)},
                Point4 = {Value = (decimal) Math.Round(maxPoint*0.75, 0)},
                Point3 = {Value = (decimal) Math.Round(maxPoint*0.6, 0)}
            };
            markform.ShowDialog();
            point5 = markform._p5;
            point4 = markform._p4;
            point3 = markform._p3;
            return markform._t;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            _p5 = (int)Point5.Value;
            _p4 = (int)Point4.Value;
            _p3 = (int)Point3.Value;
            _t = true;
            Close();
        }
    }
}
