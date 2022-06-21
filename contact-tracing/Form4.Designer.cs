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
            this.SuspendLayout();
            // 
            // savedInfoTextBox
            // 
            this.savedInfoTextBox.Location = new System.Drawing.Point(48, 37);
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
            this.whatWeReceived.Location = new System.Drawing.Point(241, 18);
            this.whatWeReceived.Name = "whatWeReceived";
            this.whatWeReceived.Size = new System.Drawing.Size(183, 16);
            this.whatWeReceived.TabIndex = 1;
            this.whatWeReceived.Text = "Here\'s What We\'ve Received";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 540);
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
    }
}