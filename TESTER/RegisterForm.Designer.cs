namespace TESTER
{
    partial class RegisterForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Test_CB = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Subject_CB = new System.Windows.Forms.ComboBox();
            this.EI_CB = new System.Windows.Forms.ComboBox();
            this.FIO_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckUpdatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.GodModeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewResultsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(485, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "© 2015-2016 Nemo-Illusionist feat. LinJay. ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Название теста";
            // 
            // Test_CB
            // 
            this.Test_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Test_CB.FormattingEnabled = true;
            this.Test_CB.Items.AddRange(new object[] {
            "(Сначала выберите предмет)"});
            this.Test_CB.Location = new System.Drawing.Point(143, 215);
            this.Test_CB.Name = "Test_CB";
            this.Test_CB.Size = new System.Drawing.Size(357, 21);
            this.Test_CB.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(15, 242);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(485, 61);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Начать тест!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Subject_CB
            // 
            this.Subject_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject_CB.FormattingEnabled = true;
            this.Subject_CB.Location = new System.Drawing.Point(143, 187);
            this.Subject_CB.Name = "Subject_CB";
            this.Subject_CB.Size = new System.Drawing.Size(357, 21);
            this.Subject_CB.TabIndex = 4;
            this.Subject_CB.Tag = "";
            this.Subject_CB.SelectedIndexChanged += new System.EventHandler(this.Subject_CB_SelectedIndexChanged);
            // 
            // EI_CB
            // 
            this.EI_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EI_CB.FormattingEnabled = true;
            this.EI_CB.Location = new System.Drawing.Point(143, 160);
            this.EI_CB.Name = "EI_CB";
            this.EI_CB.Size = new System.Drawing.Size(357, 21);
            this.EI_CB.Sorted = true;
            this.EI_CB.TabIndex = 3;
            // 
            // FIO_TextBox
            // 
            this.FIO_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO_TextBox.Location = new System.Drawing.Point(143, 108);
            this.FIO_TextBox.Name = "FIO_TextBox";
            this.FIO_TextBox.Size = new System.Drawing.Size(357, 20);
            this.FIO_TextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сдаваемый предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Учебное заведение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ваши ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добро пожаловать в EduQual Test!";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_TextBox.Location = new System.Drawing.Point(143, 134);
            this.ID_TextBox.MaxLength = 16;
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(357, 20);
            this.ID_TextBox.TabIndex = 2;
            this.ID_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Идентификационный\r\nномер";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSM,
            this.ResultsTSM,
            this.HelpTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileTSM
            // 
            this.FileTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckUpdatesTSMI,
            this.GodModeTSMI,
            this.toolStripSeparator1,
            this.ExitTSMI});
            this.FileTSM.Name = "FileTSM";
            this.FileTSM.Size = new System.Drawing.Size(48, 20);
            this.FileTSM.Text = "Файл";
            // 
            // CheckUpdatesTSMI
            // 
            this.CheckUpdatesTSMI.Enabled = false;
            this.CheckUpdatesTSMI.Name = "CheckUpdatesTSMI";
            this.CheckUpdatesTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.CheckUpdatesTSMI.Size = new System.Drawing.Size(347, 22);
            this.CheckUpdatesTSMI.Text = "Проверить обновления тестов на сервере";
            this.CheckUpdatesTSMI.Click += new System.EventHandler(this.CheckUpdatesTSMI_Click);
            // 
            // GodModeTSMI
            // 
            this.GodModeTSMI.Name = "GodModeTSMI";
            this.GodModeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.GodModeTSMI.Size = new System.Drawing.Size(347, 22);
            this.GodModeTSMI.Text = "Режим разработчика";
            this.GodModeTSMI.Click += new System.EventHandler(this.GodModeTSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(344, 6);
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitTSMI.Size = new System.Drawing.Size(347, 22);
            this.ExitTSMI.Text = "Закрыть";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // ResultsTSM
            // 
            this.ResultsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewResultsTSMI});
            this.ResultsTSM.Name = "ResultsTSM";
            this.ResultsTSM.Size = new System.Drawing.Size(81, 20);
            this.ResultsTSM.Text = "Результаты";
            // 
            // ViewResultsTSMI
            // 
            this.ViewResultsTSMI.Enabled = false;
            this.ViewResultsTSMI.Name = "ViewResultsTSMI";
            this.ViewResultsTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ViewResultsTSMI.Size = new System.Drawing.Size(276, 22);
            this.ViewResultsTSMI.Text = "Посмотреть свои результаты";
            this.ViewResultsTSMI.Click += new System.EventHandler(this.ViewResultsTSMI_Click);
            // 
            // HelpTSM
            // 
            this.HelpTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowHelpTSMI,
            this.AboutTSMI});
            this.HelpTSM.Name = "HelpTSM";
            this.HelpTSM.Size = new System.Drawing.Size(65, 20);
            this.HelpTSM.Text = "Справка";
            // 
            // ShowHelpTSMI
            // 
            this.ShowHelpTSMI.Name = "ShowHelpTSMI";
            this.ShowHelpTSMI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ShowHelpTSMI.Size = new System.Drawing.Size(191, 22);
            this.ShowHelpTSMI.Text = "Вызов справки";
            this.ShowHelpTSMI.Click += new System.EventHandler(this.ShowHelpTSMI_Click);
            // 
            // AboutTSMI
            // 
            this.AboutTSMI.Name = "AboutTSMI";
            this.AboutTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.AboutTSMI.Size = new System.Drawing.Size(191, 22);
            this.AboutTSMI.Text = "О программе";
            this.AboutTSMI.Click += new System.EventHandler(this.AboutTSMI_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTER.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(513, 336);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Test_CB);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Subject_CB);
            this.Controls.Add(this.EI_CB);
            this.Controls.Add(this.FIO_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа тестирования учащихся EduQual Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Test_CB;
        public System.Windows.Forms.ComboBox Subject_CB;
        public System.Windows.Forms.ComboBox EI_CB;
        public System.Windows.Forms.TextBox FIO_TextBox;
        public System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileTSM;
        private System.Windows.Forms.ToolStripMenuItem CheckUpdatesTSMI;
        private System.Windows.Forms.ToolStripMenuItem GodModeTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem ResultsTSM;
        private System.Windows.Forms.ToolStripMenuItem ViewResultsTSMI;
        private System.Windows.Forms.ToolStripMenuItem HelpTSM;
        private System.Windows.Forms.ToolStripMenuItem ShowHelpTSMI;
        private System.Windows.Forms.ToolStripMenuItem AboutTSMI;
    }
}