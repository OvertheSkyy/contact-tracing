﻿namespace contact_tracing
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
            this.savedInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.dateOfCreation = new System.Windows.Forms.ComboBox();
            this.dateFilterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.generateQRCode = new System.Windows.Forms.Button();
            this.QRGeneratePictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seePersonInfo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRGeneratePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // savedInfoTextBox
            // 
            this.savedInfoTextBox.BackColor = System.Drawing.Color.White;
            this.savedInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedInfoTextBox.Location = new System.Drawing.Point(316, 43);
            this.savedInfoTextBox.Name = "savedInfoTextBox";
            this.savedInfoTextBox.ReadOnly = true;
            this.savedInfoTextBox.Size = new System.Drawing.Size(215, 366);
            this.savedInfoTextBox.TabIndex = 3;
            this.savedInfoTextBox.Text = "";
            this.savedInfoTextBox.TextChanged += new System.EventHandler(this.savedInfoTextBox_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "TYPE NAME HERE:";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(40, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back and Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(177, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save and Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "All rights reserved.";
            // 
            // generateQRCode
            // 
            this.generateQRCode.BackColor = System.Drawing.Color.Transparent;
            this.generateQRCode.FlatAppearance.BorderSize = 0;
            this.generateQRCode.Location = new System.Drawing.Point(112, 366);
            this.generateQRCode.Name = "generateQRCode";
            this.generateQRCode.Size = new System.Drawing.Size(111, 23);
            this.generateQRCode.TabIndex = 13;
            this.generateQRCode.Text = "Generate QR Code";
            this.generateQRCode.UseVisualStyleBackColor = false;
            this.generateQRCode.Click += new System.EventHandler(this.generateQRCode_Click);
            // 
            // QRGeneratePictureBox
            // 
            this.QRGeneratePictureBox.BackColor = System.Drawing.Color.White;
            this.QRGeneratePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QRGeneratePictureBox.Location = new System.Drawing.Point(27, 108);
            this.QRGeneratePictureBox.Name = "QRGeneratePictureBox";
            this.QRGeneratePictureBox.Size = new System.Drawing.Size(261, 252);
            this.QRGeneratePictureBox.TabIndex = 15;
            this.QRGeneratePictureBox.TabStop = false;
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
            // seePersonInfo
            // 
            this.seePersonInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seePersonInfo.FormattingEnabled = true;
            this.seePersonInfo.Location = new System.Drawing.Point(114, 59);
            this.seePersonInfo.Name = "seePersonInfo";
            this.seePersonInfo.Size = new System.Drawing.Size(133, 21);
            this.seePersonInfo.TabIndex = 2;
            this.seePersonInfo.SelectedIndexChanged += new System.EventHandler(this.seePersonInfo_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(543, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QRGeneratePictureBox);
            this.Controls.Add(this.generateQRCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFilterLabel);
            this.Controls.Add(this.dateOfCreation);
            this.Controls.Add(this.seePersonInfo);
            this.Controls.Add(this.savedInfoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name of Contact";
            ((System.ComponentModel.ISupportInitialize)(this.QRGeneratePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox savedInfoTextBox;
        private System.Windows.Forms.ComboBox dateOfCreation;
        private System.Windows.Forms.Label dateFilterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateQRCode;
        private System.Windows.Forms.PictureBox QRGeneratePictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seePersonInfo;
    }
}