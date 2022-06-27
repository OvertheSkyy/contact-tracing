using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace contact_tracing
{
    public partial class loginForm : Form
    {
        private Thread th;
        private Thread thread;

        public loginForm()
        {
            InitializeComponent();
        }

        private void appName_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void personalInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            
            if ((username == "") || (password == ""))
            {
                MessageBox.Show("Invalid Login Credentials!");
            }
            else if (username == usernameTextBox.Text || password == passwordTextBox.Text)
            {
                MessageBox.Show("Successfully Login!");
                this.Close();
                thread = new Thread(openNewForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
   
            }
        }

        private void openNewForm()
        {
            Application.Run(new personalInfoForm());
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            privacyPolicyForm form = new privacyPolicyForm();
            form.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
