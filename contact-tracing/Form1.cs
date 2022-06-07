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

        private void firstDoseYes_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox1.Text = "Yes";
        }

        private void firstDoseNo_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox1.Text = "No";
        }

        private void secondDoseYes_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox2.Text = "Yes";
        }

        private void secondDoseNo_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox2.Text = "No";
        }

        private void checkShowBox1_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "1";
        }

        private void checkShotBox2_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "2";
        }

        private void checkShotBox3_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "3";
        }
    }
}
