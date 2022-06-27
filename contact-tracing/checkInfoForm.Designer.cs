namespace contact_tracing
{
    partial class checkInfoForm
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
            this.dateOfCreation = new System.Windows.Forms.ComboBox();
            this.dateFilterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateQRCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showNameBtn = new System.Windows.Forms.Button();
            this.savedInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.seePersonInfoComboBox = new System.Windows.Forms.ComboBox();
            this.generatedQRPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generatedQRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfCreation
            // 
            this.dateOfCreation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateOfCreation.FormattingEnabled = true;
            this.dateOfCreation.Items.AddRange(new object[] {
            "2021",
            "2022"});
            this.dateOfCreation.Location = new System.Drawing.Point(114, 32);
            this.dateOfCreation.Name = "dateOfCreation";
            this.dateOfCreation.Size = new System.Drawing.Size(133, 21);
            this.dateOfCreation.TabIndex = 1;
            // 
            // dateFilterLabel
            // 
            this.dateFilterLabel.AutoSize = true;
            this.dateFilterLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterLabel.Location = new System.Drawing.Point(12, 36);
            this.dateFilterLabel.Name = "dateFilterLabel";
            this.dateFilterLabel.Size = new System.Drawing.Size(96, 12);
            this.dateFilterLabel.TabIndex = 6;
            this.dateFilterLabel.Text = "DATE OF CREATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(335, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "WHAT WE\'VE RECEIVED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CHECK YOUR INFORMATION";
            // 
            // generateQRCode
            // 
            this.generateQRCode.BackColor = System.Drawing.Color.Transparent;
            this.generateQRCode.FlatAppearance.BorderSize = 0;
            this.generateQRCode.Location = new System.Drawing.Point(102, 381);
            this.generateQRCode.Name = "generateQRCode";
            this.generateQRCode.Size = new System.Drawing.Size(111, 23);
            this.generateQRCode.TabIndex = 13;
            this.generateQRCode.Text = "Generate QR Code";
            this.generateQRCode.UseVisualStyleBackColor = false;
            this.generateQRCode.Click += new System.EventHandler(this.generateQRCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(75, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "GENERATED QR CODE";
            // 
            // showNameBtn
            // 
            this.showNameBtn.BackColor = System.Drawing.Color.Transparent;
            this.showNameBtn.FlatAppearance.BorderSize = 0;
            this.showNameBtn.Location = new System.Drawing.Point(14, 58);
            this.showNameBtn.Name = "showNameBtn";
            this.showNameBtn.Size = new System.Drawing.Size(81, 21);
            this.showNameBtn.TabIndex = 17;
            this.showNameBtn.Text = "NAME";
            this.showNameBtn.UseVisualStyleBackColor = false;
            this.showNameBtn.Click += new System.EventHandler(this.showNameBtn_Click);
            // 
            // savedInfoRichTextBox
            // 
            this.savedInfoRichTextBox.Location = new System.Drawing.Point(326, 58);
            this.savedInfoRichTextBox.Name = "savedInfoRichTextBox";
            this.savedInfoRichTextBox.Size = new System.Drawing.Size(193, 302);
            this.savedInfoRichTextBox.TabIndex = 19;
            this.savedInfoRichTextBox.Text = "";
            // 
            // seePersonInfoComboBox
            // 
            this.seePersonInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seePersonInfoComboBox.FormattingEnabled = true;
            this.seePersonInfoComboBox.Location = new System.Drawing.Point(114, 59);
            this.seePersonInfoComboBox.Name = "seePersonInfoComboBox";
            this.seePersonInfoComboBox.Size = new System.Drawing.Size(417, 21);
            this.seePersonInfoComboBox.TabIndex = 20;
            // 
            // generatedQRPictureBox
            // 
            this.generatedQRPictureBox.BackColor = System.Drawing.Color.White;
            this.generatedQRPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generatedQRPictureBox.Location = new System.Drawing.Point(29, 108);
            this.generatedQRPictureBox.Name = "generatedQRPictureBox";
            this.generatedQRPictureBox.Size = new System.Drawing.Size(261, 252);
            this.generatedQRPictureBox.TabIndex = 21;
            this.generatedQRPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "All rights reserved.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(438, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 21);
            this.button1.TabIndex = 23;
            this.button1.Text = "NAME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(543, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatedQRPictureBox);
            this.Controls.Add(this.seePersonInfoComboBox);
            this.Controls.Add(this.showNameBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateQRCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFilterLabel);
            this.Controls.Add(this.dateOfCreation);
            this.Controls.Add(this.savedInfoRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name of Contact";
            ((System.ComponentModel.ISupportInitialize)(this.generatedQRPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dateOfCreation;
        private System.Windows.Forms.Label dateFilterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showNameBtn;
        private System.Windows.Forms.RichTextBox savedInfoRichTextBox;
        private System.Windows.Forms.ComboBox seePersonInfoComboBox;
        private System.Windows.Forms.PictureBox generatedQRPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}