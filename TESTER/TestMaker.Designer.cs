namespace TESTER
{
    partial class TestMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMaker));
            this.GoButton = new System.Windows.Forms.Button();
            this.AddAnswerButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PointCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnsType = new System.Windows.Forms.ComboBox();
            this.QuestionTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.IICheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TestNameTB = new System.Windows.Forms.TextBox();
            this.SubjectCB = new System.Windows.Forms.ComboBox();
            this.RemoveAnswerButton = new System.Windows.Forms.Button();
            this.AllTime = new System.Windows.Forms.NumericUpDown();
            this.CommitTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PointCount)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTime)).BeginInit();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.BackColor = System.Drawing.SystemColors.Control;
            this.GoButton.Location = new System.Drawing.Point(11, 96);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(641, 23);
            this.GoButton.TabIndex = 8;
            this.GoButton.Text = "Далее";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // AddAnswerButton
            // 
            this.AddAnswerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddAnswerButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddAnswerButton.Location = new System.Drawing.Point(12, 356);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(313, 23);
            this.AddAnswerButton.TabIndex = 12;
            this.AddAnswerButton.Text = "Добавить еще ответ";
            this.AddAnswerButton.UseVisualStyleBackColor = false;
            this.AddAnswerButton.Visible = false;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(12, 385);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(640, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Записать вопрос";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PointCount
            // 
            this.PointCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PointCount.Location = new System.Drawing.Point(540, 37);
            this.PointCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PointCount.Name = "PointCount";
            this.PointCount.Size = new System.Drawing.Size(73, 20);
            this.PointCount.TabIndex = 11;
            this.PointCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(376, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Количество баллов на вопрос";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Варианты ответов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип ответов";
            // 
            // AnsType
            // 
            this.AnsType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnsType.Enabled = false;
            this.AnsType.FormattingEnabled = true;
            this.AnsType.Items.AddRange(new object[] {
            "Один правильный ответ",
            "Несколько правильных ответов",
            "Нет вариантов ответов"});
            this.AnsType.Location = new System.Drawing.Point(105, 37);
            this.AnsType.Name = "AnsType";
            this.AnsType.Size = new System.Drawing.Size(150, 21);
            this.AnsType.TabIndex = 10;
            // 
            // QuestionTB
            // 
            this.QuestionTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuestionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionTB.Location = new System.Drawing.Point(105, 10);
            this.QuestionTB.Name = "QuestionTB";
            this.QuestionTB.Size = new System.Drawing.Size(508, 20);
            this.QuestionTB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вопрос";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Время на тест (в минутах)";
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.IICheck);
            this.Panel.Controls.Add(this.PointCount);
            this.Panel.Controls.Add(this.label8);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.AnsType);
            this.Panel.Controls.Add(this.QuestionTB);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Location = new System.Drawing.Point(12, 125);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(640, 225);
            this.Panel.TabIndex = 38;
            this.Panel.Visible = false;
            // 
            // IICheck
            // 
            this.IICheck.AutoSize = true;
            this.IICheck.Checked = true;
            this.IICheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IICheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IICheck.Location = new System.Drawing.Point(259, 39);
            this.IICheck.Name = "IICheck";
            this.IICheck.Size = new System.Drawing.Size(48, 17);
            this.IICheck.TabIndex = 12;
            this.IICheck.Text = "АОТ";
            this.IICheck.UseVisualStyleBackColor = true;
            this.IICheck.CheckedChanged += new System.EventHandler(this.II_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Название теста";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Название предмета";
            // 
            // TestNameTB
            // 
            this.TestNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestNameTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TestNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestNameTB.Location = new System.Drawing.Point(153, 36);
            this.TestNameTB.Name = "TestNameTB";
            this.TestNameTB.Size = new System.Drawing.Size(499, 20);
            this.TestNameTB.TabIndex = 1;
            // 
            // SubjectCB
            // 
            this.SubjectCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectCB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCB.FormattingEnabled = true;
            this.SubjectCB.Items.AddRange(new object[] {
            "Один правильный ответ",
            "Несколько правильных ответов",
            "Нет вариантов ответов"});
            this.SubjectCB.Location = new System.Drawing.Point(153, 12);
            this.SubjectCB.Name = "SubjectCB";
            this.SubjectCB.Size = new System.Drawing.Size(499, 21);
            this.SubjectCB.TabIndex = 0;
            this.SubjectCB.SelectedIndexChanged += new System.EventHandler(this.SubjectCB_SelectedIndexChanged);
            // 
            // RemoveAnswerButton
            // 
            this.RemoveAnswerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAnswerButton.Location = new System.Drawing.Point(337, 356);
            this.RemoveAnswerButton.Name = "RemoveAnswerButton";
            this.RemoveAnswerButton.Size = new System.Drawing.Size(315, 23);
            this.RemoveAnswerButton.TabIndex = 13;
            this.RemoveAnswerButton.Text = "Удалить ответ";
            this.RemoveAnswerButton.UseVisualStyleBackColor = false;
            this.RemoveAnswerButton.Visible = false;
            this.RemoveAnswerButton.Click += new System.EventHandler(this.RemovAnswerButton_Click);
            // 
            // AllTime
            // 
            this.AllTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllTime.Location = new System.Drawing.Point(153, 67);
            this.AllTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.AllTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AllTime.Name = "AllTime";
            this.AllTime.Size = new System.Drawing.Size(63, 20);
            this.AllTime.TabIndex = 3;
            this.AllTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // CommitTest
            // 
            this.CommitTest.Location = new System.Drawing.Point(12, 418);
            this.CommitTest.Name = "CommitTest";
            this.CommitTest.Size = new System.Drawing.Size(640, 23);
            this.CommitTest.TabIndex = 40;
            this.CommitTest.Text = "button1";
            this.CommitTest.UseVisualStyleBackColor = true;
            this.CommitTest.Click += new System.EventHandler(this.CommitTest_Click);
            // 
            // TestMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.Controls.Add(this.CommitTest);
            this.Controls.Add(this.RemoveAnswerButton);
            this.Controls.Add(this.SubjectCB);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.AddAnswerButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AllTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestNameTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создатель тестов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestMaker_FormClosing);
            this.Load += new System.EventHandler(this.TestMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PointCount)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button AddAnswerButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown PointCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AnsType;
        private System.Windows.Forms.TextBox QuestionTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestNameTB;
        private System.Windows.Forms.ComboBox SubjectCB;
        private System.Windows.Forms.CheckBox IICheck;
        private System.Windows.Forms.Button RemoveAnswerButton;
        private System.Windows.Forms.Button CommitTest;
        private System.Windows.Forms.NumericUpDown AllTime;
    }
}