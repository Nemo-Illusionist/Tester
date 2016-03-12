namespace TESTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkBox));
            this.Ok = new System.Windows.Forms.Button();
            this.Point3 = new System.Windows.Forms.NumericUpDown();
            this.Point5 = new System.Windows.Forms.NumericUpDown();
            this.Point4 = new System.Windows.Forms.NumericUpDown();
            this.Maxpoint = new System.Windows.Forms.Label();
            this.QuantityQuestion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Point3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point4)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 205);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(163, 25);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Сохронить";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Point3
            // 
            this.Point3.Location = new System.Drawing.Point(81, 181);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(64, 20);
            this.Point3.TabIndex = 1;
            // 
            // Point5
            // 
            this.Point5.Location = new System.Drawing.Point(81, 129);
            this.Point5.Name = "Point5";
            this.Point5.Size = new System.Drawing.Size(64, 20);
            this.Point5.TabIndex = 2;
            // 
            // Point4
            // 
            this.Point4.Location = new System.Drawing.Point(81, 155);
            this.Point4.Name = "Point4";
            this.Point4.Size = new System.Drawing.Size(64, 20);
            this.Point4.TabIndex = 3;
            // 
            // Maxpoint
            // 
            this.Maxpoint.AutoSize = true;
            this.Maxpoint.BackColor = System.Drawing.Color.Transparent;
            this.Maxpoint.Location = new System.Drawing.Point(140, 65);
            this.Maxpoint.Name = "Maxpoint";
            this.Maxpoint.Size = new System.Drawing.Size(35, 13);
            this.Maxpoint.TabIndex = 4;
            this.Maxpoint.Text = "label1";
            // 
            // QuantityQuestion
            // 
            this.QuantityQuestion.AutoSize = true;
            this.QuantityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.QuantityQuestion.Location = new System.Drawing.Point(140, 13);
            this.QuantityQuestion.Name = "QuantityQuestion";
            this.QuantityQuestion.Size = new System.Drawing.Size(35, 13);
            this.QuantityQuestion.TabIndex = 5;
            this.QuantityQuestion.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимальное \r\nкол-во баллов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 129);
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
            this.label6.Location = new System.Drawing.Point(39, 155);
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
            this.label7.Location = new System.Drawing.Point(39, 181);
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
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Кол-во вопросов:\r\n";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Баллов надо набрать на оценку:\r\n";
            // 
            // MarkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTER.Properties.Resources._65;
            this.ClientSize = new System.Drawing.Size(187, 242);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityQuestion);
            this.Controls.Add(this.Maxpoint);
            this.Controls.Add(this.Point4);
            this.Controls.Add(this.Point5);
            this.Controls.Add(this.Point3);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark";
            ((System.ComponentModel.ISupportInitialize)(this.Point3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.NumericUpDown Point3;
        private System.Windows.Forms.NumericUpDown Point5;
        private System.Windows.Forms.NumericUpDown Point4;
        private System.Windows.Forms.Label Maxpoint;
        private System.Windows.Forms.Label QuantityQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}