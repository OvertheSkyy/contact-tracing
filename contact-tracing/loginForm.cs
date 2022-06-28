using System;
using System.Threading;
using System.Windows.Forms;


namespace contact_tracing
{
    public partial class loginForm : Form
    {
        private Thread thread;

        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                MessageBox.Show("Invalid login credentials!");
            }
            else if (username == usernameTextBox.Text || password == passwordTextBox.Text)
            {
                MessageBox.Show("Welcome back," + " " + usernameTextBox.Text + "!");
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
