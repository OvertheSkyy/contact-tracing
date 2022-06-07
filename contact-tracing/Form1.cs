using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_tracing
{
    public partial class exitButton : Form
    {
        bool click = true;

        public exitButton()
        {
            InitializeComponent();
        }

        private void appName_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {

                StreamWriter file = new StreamWriter(@"", true);

                file.WriteLine(personalInfoLabel.Text);
                file.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
                file.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
                file.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
                file.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
                file.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
                file.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
                file.WriteLine(healthFormLabel.Text);
                file.WriteLine(firstDoseLabel.Text + " ");
                

                file.Close();
            
        }

        private void clearInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
