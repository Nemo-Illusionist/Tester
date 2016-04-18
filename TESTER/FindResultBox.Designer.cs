namespace TESTER
{
    partial class FindResultBox
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
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.FoundResultsLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(12, 25);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(341, 20);
            this.SearchTB.TabIndex = 0;
            // 
            // FoundResultsLV
            // 
            this.FoundResultsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.FoundResultsLV.GridLines = true;
            this.FoundResultsLV.Location = new System.Drawing.Point(12, 54);
            this.FoundResultsLV.MultiSelect = false;
            this.FoundResultsLV.Name = "FoundResultsLV";
            this.FoundResultsLV.Size = new System.Drawing.Size(419, 166);
            this.FoundResultsLV.TabIndex = 1;
            this.FoundResultsLV.UseCompatibleStateImageBehavior = false;
            this.FoundResultsLV.View = System.Windows.Forms.View.Details;
            this.FoundResultsLV.ItemActivate += new System.EventHandler(this.FoundResultsLV_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Найденые Результаты";
            this.columnHeader1.Width = 392;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ID";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(359, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(72, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FindResultBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTER.Properties.Resources._65;
            this.ClientSize = new System.Drawing.Size(443, 234);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoundResultsLV);
            this.Controls.Add(this.SearchTB);
            this.Name = "FindResultBox";
            this.Text = "FindResultBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.ListView FoundResultsLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}