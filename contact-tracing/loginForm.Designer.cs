namespace contact_tracing
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.designPanel = new System.Windows.Forms.Panel();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            this.contactInfoLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.verLabel = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.designPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(18, 318);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 33);
            this.exitBtn.TabIndex = 44;
            this.exitBtn.Text = "Exit App";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // designPanel
            // 
            this.designPanel.BackColor = System.Drawing.Color.White;
            this.designPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("designPanel.BackgroundImage")));
            this.designPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.designPanel.Controls.Add(this.usernameTextBox);
            this.designPanel.Controls.Add(this.personPictureBox);
            this.designPanel.Controls.Add(this.contactInfoLabel);
            this.designPanel.Controls.Add(this.loginBtn);
            this.designPanel.Controls.Add(this.usernameLabel);
            this.designPanel.Controls.Add(this.passwordLabel);
            this.designPanel.Controls.Add(this.passwordTextBox);
            this.designPanel.Controls.Add(this.verLabel);
            this.designPanel.Controls.Add(this.aboutBtn);
            this.designPanel.Controls.Add(this.exitBtn);
            this.designPanel.ForeColor = System.Drawing.Color.White;
            this.designPanel.Location = new System.Drawing.Point(15, 33);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(233, 377);
            this.designPanel.TabIndex = 66;
            // 
            // personPictureBox
            // 
            this.personPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.personPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personPictureBox.BackgroundImage")));
            this.personPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personPictureBox.Location = new System.Drawing.Point(46, 24);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(149, 121);
            this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.personPictureBox.TabIndex = 78;
            this.personPictureBox.TabStop = false;
            // 
            // contactInfoLabel
            // 
            this.contactInfoLabel.AutoSize = true;
            this.contactInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactInfoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.contactInfoLabel.Location = new System.Drawing.Point(38, 148);
            this.contactInfoLabel.Name = "contactInfoLabel";
            this.contactInfoLabel.Size = new System.Drawing.Size(165, 21);
            this.contactInfoLabel.TabIndex = 77;
            this.contactInfoLabel.Text = "Contact Information";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(18, 259);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(196, 33);
            this.loginBtn.TabIndex = 76;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(40, 178);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 75;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(42, 217);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 74;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(42, 233);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(152, 20);
            this.passwordTextBox.TabIndex = 71;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.BackColor = System.Drawing.Color.Transparent;
            this.verLabel.ForeColor = System.Drawing.Color.Black;
            this.verLabel.Location = new System.Drawing.Point(3, 363);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(40, 13);
            this.verLabel.TabIndex = 69;
            this.verLabel.Text = "ver 1.0";
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.Black;
            this.aboutBtn.Location = new System.Drawing.Point(18, 289);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(196, 33);
            this.aboutBtn.TabIndex = 66;
            this.aboutBtn.Text = "About App";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.appNameLabel.Location = new System.Drawing.Point(3, 14);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(250, 16);
            this.appNameLabel.TabIndex = 67;
            this.appNameLabel.Text = "COVID 19 - Health Contact Tracing App";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(42, 194);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(152, 20);
            this.usernameTextBox.TabIndex = 79;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(264, 423);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.designPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.designPanel.ResumeLayout(false);
            this.designPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label contactInfoLabel;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}

