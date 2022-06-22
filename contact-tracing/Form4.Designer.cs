namespace contact_tracing
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.savedInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.seePersonInfo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateFilterLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // savedInfoTextBox
            // 
            this.savedInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedInfoTextBox.Location = new System.Drawing.Point(348, 103);
            this.savedInfoTextBox.Name = "savedInfoTextBox";
            this.savedInfoTextBox.ReadOnly = true;
            this.savedInfoTextBox.Size = new System.Drawing.Size(183, 232);
            this.savedInfoTextBox.TabIndex = 1;
            this.savedInfoTextBox.Text = "";
            this.savedInfoTextBox.TextChanged += new System.EventHandler(this.savedInfoTextBox_TextChanged);
            // 
            // seePersonInfo
            // 
            this.seePersonInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seePersonInfo.FormattingEnabled = true;
            this.seePersonInfo.Items.AddRange(new object[] {
            "Cassie Mondragon",
            "Sherri Shah",
            "Rolando Doyle",
            "Mickey Rowland",
            "Ezequiel Berger",
            "Beatrice Morgan",
            "Lori Caldwell",
            "Eileen Burns",
            "Dana Love",
            "Vicky Vaughan"});
            this.seePersonInfo.Location = new System.Drawing.Point(110, 59);
            this.seePersonInfo.Name = "seePersonInfo";
            this.seePersonInfo.Size = new System.Drawing.Size(121, 21);
            this.seePersonInfo.TabIndex = 2;
            this.seePersonInfo.SelectedIndexChanged += new System.EventHandler(this.seePersonInfo_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dateFilterLabel
            // 
            this.dateFilterLabel.AutoSize = true;
            this.dateFilterLabel.BackColor = System.Drawing.Color.White;
            this.dateFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterLabel.Location = new System.Drawing.Point(12, 36);
            this.dateFilterLabel.Name = "dateFilterLabel";
            this.dateFilterLabel.Size = new System.Drawing.Size(92, 12);
            this.dateFilterLabel.TabIndex = 6;
            this.dateFilterLabel.Text = "DATE OF CONTACT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-35, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 432);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(534, 430);
            this.Controls.Add(this.dateFilterLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.seePersonInfo);
            this.Controls.Add(this.savedInfoTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name of Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox savedInfoTextBox;
        private System.Windows.Forms.ComboBox seePersonInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dateFilterLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}