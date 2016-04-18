namespace TESTER
{
    partial class DeveloperBox
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
            this.CreateTestButton = new System.Windows.Forms.Button();
            this.EditTestButton = new System.Windows.Forms.Button();
            this.ChangeEIListButton = new System.Windows.Forms.Button();
            this.ClearUserFolderButton = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateTestButton
            // 
            this.CreateTestButton.Location = new System.Drawing.Point(12, 51);
            this.CreateTestButton.Name = "CreateTestButton";
            this.CreateTestButton.Size = new System.Drawing.Size(240, 23);
            this.CreateTestButton.TabIndex = 1;
            this.CreateTestButton.Text = "Создать тест";
            this.CreateTestButton.UseVisualStyleBackColor = true;
            this.CreateTestButton.Click += new System.EventHandler(this.CreateTestButton_Click);
            // 
            // EditTestButton
            // 
            this.EditTestButton.Enabled = false;
            this.EditTestButton.Location = new System.Drawing.Point(12, 80);
            this.EditTestButton.Name = "EditTestButton";
            this.EditTestButton.Size = new System.Drawing.Size(240, 23);
            this.EditTestButton.TabIndex = 2;
            this.EditTestButton.Text = "Редактировать тест";
            this.EditTestButton.UseVisualStyleBackColor = true;
            this.EditTestButton.Click += new System.EventHandler(this.EditTestButton_Click);
            // 
            // ChangeEIListButton
            // 
            this.ChangeEIListButton.Location = new System.Drawing.Point(12, 109);
            this.ChangeEIListButton.Name = "ChangeEIListButton";
            this.ChangeEIListButton.Size = new System.Drawing.Size(240, 23);
            this.ChangeEIListButton.TabIndex = 3;
            this.ChangeEIListButton.Text = "Редактировать список учебных заведений";
            this.ChangeEIListButton.UseVisualStyleBackColor = true;
            this.ChangeEIListButton.Click += new System.EventHandler(this.ChangeEIListButton_Click);
            // 
            // ClearUserFolderButton
            // 
            this.ClearUserFolderButton.Location = new System.Drawing.Point(12, 138);
            this.ClearUserFolderButton.Name = "ClearUserFolderButton";
            this.ClearUserFolderButton.Size = new System.Drawing.Size(240, 23);
            this.ClearUserFolderButton.TabIndex = 4;
            this.ClearUserFolderButton.Text = "Очистить папку результатов";
            this.ClearUserFolderButton.UseVisualStyleBackColor = true;
            this.ClearUserFolderButton.Click += new System.EventHandler(this.ClearUserFolderButton_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(12, 25);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(240, 20);
            this.PasswordTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите, пожалуйста, пароль (God)";
            // 
            // DeveloperBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::TESTER.Properties.Resources._65;
            this.ClientSize = new System.Drawing.Size(265, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.ClearUserFolderButton);
            this.Controls.Add(this.ChangeEIListButton);
            this.Controls.Add(this.EditTestButton);
            this.Controls.Add(this.CreateTestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeveloperBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим разработчика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeveloperBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTestButton;
        private System.Windows.Forms.Button EditTestButton;
        private System.Windows.Forms.Button ChangeEIListButton;
        private System.Windows.Forms.Button ClearUserFolderButton;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
    }
}