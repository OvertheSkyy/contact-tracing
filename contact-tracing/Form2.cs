﻿using System;
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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
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

        private void secondDoseYes_CheckedChanged_1(object sender, EventArgs e)
        {
            answerTextBox2.Text = "Yes";
        }

        private void secondDoseNo_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox2.Text = "No";
        }

        private void boosterShotBox0_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "0";
        }

        private void boosterShotBox1_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "1";
        }

        private void boosterShotBox2_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "2";
        }

        private void boosterShotBox3_CheckedChanged(object sender, EventArgs e)
        {
            answerTextBox3.Text = "3";
        }

        private void saveInfoBtn_Click(object sender, EventArgs e)
        {
  
                StreamWriter file = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\contacts.txt", true);

                file.WriteLine(personInfoLabel.Text);
                file.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
                file.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
                file.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
                file.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
                file.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
                file.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
                file.WriteLine(healthFormLabel.Text);
                file.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
                file.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
                file.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
                file.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
                file.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
                file.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
                file.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);

                file.Close();
      
        }
    }
}
