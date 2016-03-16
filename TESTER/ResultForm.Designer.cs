namespace TESTER
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 40D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.AnswersView = new System.Windows.Forms.ListView();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrueAns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.YourMarkLabel = new System.Windows.Forms.Label();
            this.YourPointsLabel = new System.Windows.Forms.Label();
            this.TrololoPB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TrololoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // AnswersView
            // 
            this.AnswersView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.Point,
            this.UserAns,
            this.TrueAns});
            this.AnswersView.FullRowSelect = true;
            this.AnswersView.GridLines = true;
            this.AnswersView.Location = new System.Drawing.Point(498, 12);
            this.AnswersView.Name = "AnswersView";
            this.AnswersView.Size = new System.Drawing.Size(450, 538);
            this.AnswersView.TabIndex = 1;
            this.AnswersView.UseCompatibleStateImageBehavior = false;
            this.AnswersView.View = System.Windows.Forms.View.Details;
            // 
            // N
            // 
            this.N.Text = "№ ";
            this.N.Width = 25;
            // 
            // Point
            // 
            this.Point.Text = "Балл";
            this.Point.Width = 40;
            // 
            // UserAns
            // 
            this.UserAns.Text = "Ваш ответ";
            this.UserAns.Width = 180;
            // 
            // TrueAns
            // 
            this.TrueAns.Text = "Правильный ответ";
            this.TrueAns.Width = 180;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Просмотр результатов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YourMarkLabel
            // 
            this.YourMarkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YourMarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourMarkLabel.Location = new System.Drawing.Point(454, 214);
            this.YourMarkLabel.Name = "YourMarkLabel";
            this.YourMarkLabel.Size = new System.Drawing.Size(36, 16);
            this.YourMarkLabel.TabIndex = 4;
            this.YourMarkLabel.Text = "5";
            this.YourMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YourPointsLabel
            // 
            this.YourPointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YourPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourPointsLabel.Location = new System.Drawing.Point(457, 233);
            this.YourPointsLabel.Name = "YourPointsLabel";
            this.YourPointsLabel.Size = new System.Drawing.Size(33, 16);
            this.YourPointsLabel.TabIndex = 5;
            this.YourPointsLabel.Text = "100";
            this.YourPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TrololoPB
            // 
            this.TrololoPB.BackColor = System.Drawing.Color.Transparent;
            this.TrololoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TrololoPB.Location = new System.Drawing.Point(10, 49);
            this.TrololoPB.Name = "TrololoPB";
            this.TrololoPB.Size = new System.Drawing.Size(200, 200);
            this.TrololoPB.TabIndex = 6;
            this.TrololoPB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(218, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ваша оценка: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(218, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество баллов: ";
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(218, 54);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(274, 160);
            this.InfoLabel.TabIndex = 9;
            // 
            // Diagram
            // 
            this.Diagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diagram.BackColor = System.Drawing.Color.Transparent;
            this.Diagram.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Diagram.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            this.Diagram.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Diagram.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.Diagram.Legends.Add(legend1);
            this.Diagram.Location = new System.Drawing.Point(10, 255);
            this.Diagram.Name = "Diagram";
            this.Diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            dataPoint1.AxisLabel = "";
            dataPoint1.Color = System.Drawing.Color.Blue;
            dataPoint1.Label = "";
            dataPoint1.LegendText = "Правильно";
            dataPoint1.MarkerColor = System.Drawing.Color.Lime;
            dataPoint2.AxisLabel = "";
            dataPoint2.Color = System.Drawing.Color.Red;
            dataPoint2.LegendText = "Неправильно";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.Diagram.Series.Add(series1);
            this.Diagram.Size = new System.Drawing.Size(480, 295);
            this.Diagram.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTER.Properties.Resources._65;
            this.ClientSize = new System.Drawing.Size(954, 562);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrololoPB);
            this.Controls.Add(this.YourPointsLabel);
            this.Controls.Add(this.YourMarkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswersView);
            this.Controls.Add(this.Diagram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 600);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест завершен. Посмотрите результаты!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrololoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader UserAns;
        private System.Windows.Forms.ColumnHeader TrueAns;
        private System.Windows.Forms.ColumnHeader Point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox TrololoPB;
        public System.Windows.Forms.ListView AnswersView;
        public System.Windows.Forms.Label YourMarkLabel;
        public System.Windows.Forms.Label YourPointsLabel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart Diagram;
    }
}