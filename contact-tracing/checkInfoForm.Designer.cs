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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkInfoForm));
            this.dateOfCreation = new System.Windows.Forms.ComboBox();
            this.dateFilterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateQRCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generatedQRPictureBox = new System.Windows.Forms.PictureBox();
            this.allRightsReservedLabel = new System.Windows.Forms.Label();
            this.seePersonInfoComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.savedInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.generatedQRPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfCreation
            // 
            this.dateOfCreation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateOfCreation.FormattingEnabled = true;
            this.dateOfCreation.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.dateOfCreation.Location = new System.Drawing.Point(102, 32);
            this.dateOfCreation.Name = "dateOfCreation";
            this.dateOfCreation.Size = new System.Drawing.Size(133, 21);
            this.dateOfCreation.TabIndex = 1;
            this.dateOfCreation.SelectedIndexChanged += new System.EventHandler(this.dateOfCreation_SelectedIndexChanged);
            // 
            // dateFilterLabel
            // 
            this.dateFilterLabel.AutoSize = true;
            this.dateFilterLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterLabel.Location = new System.Drawing.Point(2, 36);
            this.dateFilterLabel.Name = "dateFilterLabel";
            this.dateFilterLabel.Size = new System.Drawing.Size(96, 12);
            this.dateFilterLabel.TabIndex = 6;
            this.dateFilterLabel.Text = "YEAR OF CREATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(339, 149);
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
            this.label4.Location = new System.Drawing.Point(169, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CHECK YOUR INFORMATION";
            // 
            // generateQRCode
            // 
            this.generateQRCode.BackColor = System.Drawing.Color.Transparent;
            this.generateQRCode.FlatAppearance.BorderSize = 0;
            this.generateQRCode.Location = new System.Drawing.Point(90, 454);
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
            this.label2.Location = new System.Drawing.Point(71, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "GENERATED QR CODE";
            // 
            // generatedQRPictureBox
            // 
            this.generatedQRPictureBox.BackColor = System.Drawing.Color.White;
            this.generatedQRPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generatedQRPictureBox.Location = new System.Drawing.Point(12, 168);
            this.generatedQRPictureBox.Name = "generatedQRPictureBox";
            this.generatedQRPictureBox.Size = new System.Drawing.Size(282, 280);
            this.generatedQRPictureBox.TabIndex = 21;
            this.generatedQRPictureBox.TabStop = false;
            // 
            // allRightsReservedLabel
            // 
            this.allRightsReservedLabel.AutoSize = true;
            this.allRightsReservedLabel.BackColor = System.Drawing.Color.Transparent;
            this.allRightsReservedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRightsReservedLabel.Location = new System.Drawing.Point(1, 484);
            this.allRightsReservedLabel.Name = "allRightsReservedLabel";
            this.allRightsReservedLabel.Size = new System.Drawing.Size(83, 12);
            this.allRightsReservedLabel.TabIndex = 22;
            this.allRightsReservedLabel.Text = "All rights reserved.";
            // 
            // seePersonInfoComboBox
            // 
            this.seePersonInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seePersonInfoComboBox.FormattingEnabled = true;
            this.seePersonInfoComboBox.Items.AddRange(new object[] {
            ""});
            this.seePersonInfoComboBox.Location = new System.Drawing.Point(102, 59);
            this.seePersonInfoComboBox.Name = "seePersonInfoComboBox";
            this.seePersonInfoComboBox.Size = new System.Drawing.Size(367, 21);
            this.seePersonInfoComboBox.TabIndex = 24;
            this.seePersonInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.seePersonInfoComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "LOOK FOR NAME:";
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeFormBtn.FlatAppearance.BorderSize = 0;
            this.closeFormBtn.Location = new System.Drawing.Point(485, 27);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(60, 21);
            this.closeFormBtn.TabIndex = 30;
            this.closeFormBtn.Text = "Close";
            this.closeFormBtn.UseVisualStyleBackColor = false;
            this.closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // savedInfoRichTextBox
            // 
            this.savedInfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedInfoRichTextBox.Location = new System.Drawing.Point(310, 168);
            this.savedInfoRichTextBox.Name = "savedInfoRichTextBox";
            this.savedInfoRichTextBox.Size = new System.Drawing.Size(235, 280);
            this.savedInfoRichTextBox.TabIndex = 31;
            this.savedInfoRichTextBox.Text = "";
            // 
            // checkInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 500);
            this.Controls.Add(this.savedInfoRichTextBox);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seePersonInfoComboBox);
            this.Controls.Add(this.allRightsReservedLabel);
            this.Controls.Add(this.generatedQRPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateQRCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFilterLabel);
            this.Controls.Add(this.dateOfCreation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "checkInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Your Information";
            this.Load += new System.EventHandler(this.checkInfoForm_Load);
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
        private System.Windows.Forms.PictureBox generatedQRPictureBox;
        private System.Windows.Forms.Label allRightsReservedLabel;
        private System.Windows.Forms.ComboBox seePersonInfoComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.RichTextBox savedInfoRichTextBox;
    }
}