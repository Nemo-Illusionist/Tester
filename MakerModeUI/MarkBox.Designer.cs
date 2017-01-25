namespace MakerModeUI
{
    partial class MarkBox
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
            this.Ok = new System.Windows.Forms.Button();
            this.Point3 = new System.Windows.Forms.NumericUpDown();
            this.Point5 = new System.Windows.Forms.NumericUpDown();
            this.Point4 = new System.Windows.Forms.NumericUpDown();
            this.MaxPoint = new System.Windows.Forms.Label();
            this.QuantityQuestion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Percent4 = new System.Windows.Forms.NumericUpDown();
            this.Percent5 = new System.Windows.Forms.NumericUpDown();
            this.Percent3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Point3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Percent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Percent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Percent3)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 155);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(230, 25);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Сохранить";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Point3
            // 
            this.Point3.Location = new System.Drawing.Point(40, 129);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(64, 20);
            this.Point3.TabIndex = 1;
            this.Point3.ValueChanged += new System.EventHandler(this.Points_ValueChanged);
            // 
            // Point5
            // 
            this.Point5.Location = new System.Drawing.Point(40, 77);
            this.Point5.Name = "Point5";
            this.Point5.Size = new System.Drawing.Size(64, 20);
            this.Point5.TabIndex = 2;
            this.Point5.ValueChanged += new System.EventHandler(this.Points_ValueChanged);
            // 
            // Point4
            // 
            this.Point4.Location = new System.Drawing.Point(40, 103);
            this.Point4.Name = "Point4";
            this.Point4.Size = new System.Drawing.Size(64, 20);
            this.Point4.TabIndex = 3;
            this.Point4.ValueChanged += new System.EventHandler(this.Points_ValueChanged);
            // 
            // MaxPoint
            // 
            this.MaxPoint.BackColor = System.Drawing.Color.Transparent;
            this.MaxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxPoint.Location = new System.Drawing.Point(207, 35);
            this.MaxPoint.Name = "MaxPoint";
            this.MaxPoint.Size = new System.Drawing.Size(35, 15);
            this.MaxPoint.TabIndex = 4;
            this.MaxPoint.Text = "label1";
            this.MaxPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuantityQuestion
            // 
            this.QuantityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.QuantityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityQuestion.Location = new System.Drawing.Point(207, 10);
            this.QuantityQuestion.Name = "QuantityQuestion";
            this.QuantityQuestion.Size = new System.Drawing.Size(35, 15);
            this.QuantityQuestion.TabIndex = 5;
            this.QuantityQuestion.Text = "label2";
            this.QuantityQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимальное количество баллов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество вопросов:\r\n";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(9, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Баллов надо набрать на оценку:\r\n";
            // 
            // Percent4
            // 
            this.Percent4.Location = new System.Drawing.Point(152, 103);
            this.Percent4.Name = "Percent4";
            this.Percent4.Size = new System.Drawing.Size(64, 20);
            this.Percent4.TabIndex = 15;
            this.Percent4.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.Percent4.ValueChanged += new System.EventHandler(this.Percents_ValueChanged);
            // 
            // Percent5
            // 
            this.Percent5.Location = new System.Drawing.Point(152, 77);
            this.Percent5.Name = "Percent5";
            this.Percent5.Size = new System.Drawing.Size(64, 20);
            this.Percent5.TabIndex = 14;
            this.Percent5.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.Percent5.ValueChanged += new System.EventHandler(this.Percents_ValueChanged);
            // 
            // Percent3
            // 
            this.Percent3.Location = new System.Drawing.Point(152, 129);
            this.Percent3.Name = "Percent3";
            this.Percent3.Size = new System.Drawing.Size(64, 20);
            this.Percent3.TabIndex = 13;
            this.Percent3.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Percent3.ValueChanged += new System.EventHandler(this.Percents_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(218, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(216, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "%";
            // 
            // MarkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 192);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Percent4);
            this.Controls.Add(this.Percent5);
            this.Controls.Add(this.Percent3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityQuestion);
            this.Controls.Add(this.MaxPoint);
            this.Controls.Add(this.Point4);
            this.Controls.Add(this.Point5);
            this.Controls.Add(this.Point3);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark";
            ((System.ComponentModel.ISupportInitialize)(this.Point3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Percent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Percent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Percent3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.NumericUpDown Point3;
        private System.Windows.Forms.NumericUpDown Point5;
        private System.Windows.Forms.NumericUpDown Point4;
        private System.Windows.Forms.Label MaxPoint;
        private System.Windows.Forms.Label QuantityQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Percent4;
        private System.Windows.Forms.NumericUpDown Percent5;
        private System.Windows.Forms.NumericUpDown Percent3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}