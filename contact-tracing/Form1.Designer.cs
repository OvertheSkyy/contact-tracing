namespace contact_tracing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.appName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.youLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addInfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.appName.Location = new System.Drawing.Point(9, 14);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(250, 16);
            this.appName.TabIndex = 0;
            this.appName.Text = "COVID 19 - Health Contact Tracing App";
            this.appName.Click += new System.EventHandler(this.appName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(14, 186);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(209, 21);
            this.personalInfoLabel.TabIndex = 19;
            this.personalInfoLabel.Text = "PERSONAL INFORMATION";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(353, 500);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(338, 500);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 24);
            this.label19.TabIndex = 40;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(18, 311);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 33);
            this.exitBtn.TabIndex = 44;
            this.exitBtn.Text = "Exit App";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(39, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.youLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addInfoBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.personalInfoLabel);
            this.panel1.Location = new System.Drawing.Point(15, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 356);
            this.panel1.TabIndex = 66;
            // 
            // youLabel
            // 
            this.youLabel.AutoSize = true;
            this.youLabel.BackColor = System.Drawing.Color.Transparent;
            this.youLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youLabel.Location = new System.Drawing.Point(87, 137);
            this.youLabel.Name = "youLabel";
            this.youLabel.Size = new System.Drawing.Size(62, 21);
            this.youLabel.TabIndex = 67;
            this.youLabel.Text = "Person";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 33);
            this.button1.TabIndex = 66;
            this.button1.Text = "About App";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addInfoBtn
            // 
            this.addInfoBtn.Location = new System.Drawing.Point(18, 233);
            this.addInfoBtn.Name = "addInfoBtn";
            this.addInfoBtn.Size = new System.Drawing.Size(196, 33);
            this.addInfoBtn.TabIndex = 65;
            this.addInfoBtn.Text = "Edit Info";
            this.addInfoBtn.UseVisualStyleBackColor = true;
            this.addInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "ver 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(266, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addInfoBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label youLabel;
    }
}

