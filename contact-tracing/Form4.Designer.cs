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
            this.savedInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.whatWeReceived = new System.Windows.Forms.Label();
            this.showInfoBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // savedInfoTextBox
            // 
            this.savedInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedInfoTextBox.Location = new System.Drawing.Point(299, 46);
            this.savedInfoTextBox.Name = "savedInfoTextBox";
            this.savedInfoTextBox.Size = new System.Drawing.Size(559, 434);
            this.savedInfoTextBox.TabIndex = 0;
            this.savedInfoTextBox.Text = "";
            this.savedInfoTextBox.TextChanged += new System.EventHandler(this.savedInfoTextBox_TextChanged);
            // 
            // whatWeReceived
            // 
            this.whatWeReceived.AutoSize = true;
            this.whatWeReceived.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatWeReceived.Location = new System.Drawing.Point(516, 27);
            this.whatWeReceived.Name = "whatWeReceived";
            this.whatWeReceived.Size = new System.Drawing.Size(183, 16);
            this.whatWeReceived.TabIndex = 1;
            this.whatWeReceived.Text = "Here\'s What We\'ve Received";
            // 
            // showInfoBtn
            // 
            this.showInfoBtn.Location = new System.Drawing.Point(417, 498);
            this.showInfoBtn.Name = "showInfoBtn";
            this.showInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.showInfoBtn.TabIndex = 2;
            this.showInfoBtn.Text = "Show Info";
            this.showInfoBtn.UseVisualStyleBackColor = true;
            this.showInfoBtn.Click += new System.EventHandler(this.showInfoBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(43, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 742);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.showInfoBtn);
            this.Controls.Add(this.whatWeReceived);
            this.Controls.Add(this.savedInfoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox savedInfoTextBox;
        private System.Windows.Forms.Label whatWeReceived;
        private System.Windows.Forms.Button showInfoBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}