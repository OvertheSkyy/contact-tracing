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
using QRCoder;

namespace contact_tracing
{
    public partial class personalInfoForm : Form
    {

        public personalInfoForm()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
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

        private void clearSec1_Click(object sender, EventArgs e)
        {
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            middleInitialTextBox.Text = "";
        }

        private void clearSec2_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = "";
        }

        private void clearSec3_Click(object sender, EventArgs e)
        {
            dateOfBirthTextBox.Text = "";
            ageTextBox.Text = "";
        }

        private void clearSec4_Click(object sender, EventArgs e)
        {
            sexTextBox.Text = "";
            contactNoTextBox.Text = "";
        }

        private void clearSec5_Click(object sender, EventArgs e)
        {
            firstDoseYes.Checked = false;
            firstDoseNo.Checked = false;
            answerTextBox1.Text = "";
        }

        private void clearSec6_Click(object sender, EventArgs e)
        {
            firstDoseDateTextBox.Text = "";
            vaccineBrandTextBox1.Text = "";
        }

        private void clearSec7_Click(object sender, EventArgs e)
        {
            secondDoseYes.Checked = false;
            secondDoseNo.Checked = false;
            answerTextBox2.Text = "";
        }

        private void clearSec8_Click(object sender, EventArgs e)
        {
            secondDoseDateTextBox.Text = "";
            vaccineBrandTextBox2.Text = "";
        }

        private void clearSec9_Click(object sender, EventArgs e)
        {
            boosterShotBox0.Checked = false;
            boosterShotBox1.Checked = false;
            boosterShotBox2.Checked = false;
            boosterShotBox3.Checked = false;
            answerTextBox3.Text = "";
        }

        private void saveInfoBtn_Click(object sender, EventArgs e)
        {

            if (lastNameTextBox.Text == "Mondragon" && dateOfCreationComboBox.Text == "2021")
                person1yr2021();
            if (lastNameTextBox.Text == "Mondragon" && dateOfCreationComboBox.Text == "2022")
                person1yr2022();
            else if (lastNameTextBox.Text == "Shah" && dateOfCreationComboBox.Text == "2021")
                person2yr2021();
            else if (lastNameTextBox.Text == "Shah" && dateOfCreationComboBox.Text == "2022")
                person2yr2022();
            else if (lastNameTextBox.Text == "Doyle" && dateOfCreationComboBox.Text == "2021")
                person3yr2021();
            else if (lastNameTextBox.Text == "Doyle" && dateOfCreationComboBox.Text == "2022")
                person3yr2022();
            else if (lastNameTextBox.Text == "Rowland" && dateOfCreationComboBox.Text == "2021")
                person4yr2021();
            else if (lastNameTextBox.Text == "Rowland" && dateOfCreationComboBox.Text == "2022")
                person4yr2022();
            else if (lastNameTextBox.Text == "Berger" && dateOfCreationComboBox.Text == "2021")
                person5yr2021();
            else if (lastNameTextBox.Text == "Berger" && dateOfCreationComboBox.Text == "2022")
                person5yr2022();
            else if (lastNameTextBox.Text == "Morgan" && dateOfCreationComboBox.Text == "2021")
                person6yr2021();
            else if (lastNameTextBox.Text == "Morgan" && dateOfCreationComboBox.Text == "2022")
                person6yr2022();
            else if (lastNameTextBox.Text == "Caldwell" && dateOfCreationComboBox.Text == "2021")
                person7yr2021();
            else if (lastNameTextBox.Text == "Caldwell" && dateOfCreationComboBox.Text == "2022")
                person7yr2022();
            else if (lastNameTextBox.Text == "Burns" && dateOfCreationComboBox.Text == "2021")
                person8yr2021();
            else if (lastNameTextBox.Text == "Burns" && dateOfCreationComboBox.Text == "2022")
                person8yr2022();
            else if (lastNameTextBox.Text == "Vaughan" && dateOfCreationComboBox.Text == "2021")
                person9yr2021();
            else if (lastNameTextBox.Text == "Vaughan" && dateOfCreationComboBox.Text == "2022")
                person9yr2022();
            else if (lastNameTextBox.Text == "Love" && dateOfCreationComboBox.Text == "2021")
                person10yr2021();
            else if (lastNameTextBox.Text == "Love" && dateOfCreationComboBox.Text == "2022")
                person10yr2022();

        }

        private void personInfoQRCode()
        {
            if (lastNameTextBox.Text == "Mondragon" && dateOfCreationComboBox.Text == "2021")
                person1yr2021();
            if (lastNameTextBox.Text == "Mondragon" && dateOfCreationComboBox.Text == "2022")
                person1yr2022();
            else if (lastNameTextBox.Text == "Shah" && dateOfCreationComboBox.Text == "2021")
                person2yr2021();
            else if (lastNameTextBox.Text == "Shah" && dateOfCreationComboBox.Text == "2022")
                person2yr2022();
            else if (lastNameTextBox.Text == "Doyle" && dateOfCreationComboBox.Text == "2021")
                person3yr2021();
            else if (lastNameTextBox.Text == "Doyle" && dateOfCreationComboBox.Text == "2022")
                person3yr2022();
            else if (lastNameTextBox.Text == "Rowland" && dateOfCreationComboBox.Text == "2021")
                person4yr2021();
            else if (lastNameTextBox.Text == "Rowland" && dateOfCreationComboBox.Text == "2022")
                person4yr2022();
            else if (lastNameTextBox.Text == "Berger" && dateOfCreationComboBox.Text == "2021")
                person5yr2021();
            else if (lastNameTextBox.Text == "Berger" && dateOfCreationComboBox.Text == "2022")
                person5yr2022();
            else if (lastNameTextBox.Text == "Morgan" && dateOfCreationComboBox.Text == "2021")
                person6yr2021();
            else if (lastNameTextBox.Text == "Morgan" && dateOfCreationComboBox.Text == "2022")
                person6yr2022();
            else if (lastNameTextBox.Text == "Caldwell" && dateOfCreationComboBox.Text == "2021")
                person7yr2021();
            else if (lastNameTextBox.Text == "Caldwell" && dateOfCreationComboBox.Text == "2022")
                person7yr2022();
            else if (lastNameTextBox.Text == "Burns" && dateOfCreationComboBox.Text == "2021")
                person8yr2021();
            else if (lastNameTextBox.Text == "Burns" && dateOfCreationComboBox.Text == "2022")
                person8yr2022();
            else if (lastNameTextBox.Text == "Vaughan" && dateOfCreationComboBox.Text == "2021")
                person9yr2021();
            else if (lastNameTextBox.Text == "Vaughan" && dateOfCreationComboBox.Text == "2022")
                person9yr2022();
            else if (lastNameTextBox.Text == "Love" && dateOfCreationComboBox.Text == "2021")
                person10yr2021();
            else if (lastNameTextBox.Text == "Love" && dateOfCreationComboBox.Text == "2022")
                person10yr2022();
        }


        private void person1yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Cassie Mondragon.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person2yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Sherri Shah.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person3yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Rolando Doyle.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person4yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Mickey Rowland.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person5yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Ezequiel Berger.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person6yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Beatrice Morgan.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person7yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Lori Caldwell.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person8yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Eileen Burns.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person9yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Dana Love.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person10yr2021()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Vicky Vaughan.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person1yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Cassie Mondragon.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person2yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Sherri Shah.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person3yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Rolando Doyle.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person4yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Mickey Rowland.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person5yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Ezequiel Berger.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person6yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Beatrice Morgan.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person7yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Lori Caldwell.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person8yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Eileen Burns.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person9yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Dana Love.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void person10yr2022()
        {
            StreamWriter outputFile = new StreamWriter(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Vicky Vaughan.txt");

            outputFile.WriteLine(personInfoLabel.Text);
            outputFile.WriteLine(nameLabel.Text + " " + lastNameTextBox.Text + "," + " " + firstNameTextBox.Text + " " + middleInitialTextBox.Text);
            outputFile.WriteLine(addressLabel.Text + " " + addressTextBox.Text);
            outputFile.WriteLine(dateOfBirthLabel.Text + " " + dateOfBirthTextBox.Text);
            outputFile.WriteLine(ageLabel.Text + " " + ageTextBox.Text);
            outputFile.WriteLine(sexLabel.Text + " " + sexTextBox.Text);
            outputFile.WriteLine(contactNoLabel.Text + " " + contactNoTextBox.Text);
            outputFile.WriteLine(healthFormLabel.Text);
            outputFile.WriteLine(firstDoseLabel.Text + " " + answerTextBox1.Text);
            outputFile.WriteLine(firstDoseDate.Text + " " + firstDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel1.Text + " " + vaccineBrandTextBox1.Text);
            outputFile.WriteLine(secondDoseLabel.Text + " " + answerTextBox2.Text);
            outputFile.WriteLine(secondDoseDate.Text + " " + secondDoseDateTextBox.Text);
            outputFile.WriteLine(vaccineBrandLabel2.Text + " " + vaccineBrandTextBox2.Text);
            outputFile.WriteLine(boosterShotsLabel.Text + " " + answerTextBox3.Text);
            outputFile.WriteLine("Year of creation:" + " " + dateOfCreationComboBox.Text);

            outputFile.Close();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {

            firstDoseYes.Checked = false;
            firstDoseNo.Checked = false;
            secondDoseYes.Checked = false;
            secondDoseNo.Checked = false;
            boosterShotBox0.Checked = false;
            boosterShotBox1.Checked = false;
            boosterShotBox2.Checked = false;
            boosterShotBox3.Checked = false;

            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            middleInitialTextBox.Text = "";
            addressTextBox.Text = "";
            dateOfBirthTextBox.Text = "";
            ageTextBox.Text = "";
            sexTextBox.Text = "";
            contactNoTextBox.Text = "";
            answerTextBox1.Text = "";
            firstDoseDateTextBox.Text = "";
            vaccineBrandTextBox1.Text = "";
            answerTextBox2.Text = "";
            secondDoseDateTextBox.Text = "";
            vaccineBrandTextBox2.Text = "";
            answerTextBox3.Text = "";
        }

        private void returnHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seeInfo_Click(object sender, EventArgs e)
        {
            Form3 closeform = new Form3();
            closeform.Close();
            Form4 form = new Form4();
            form.Show();
        }
    }
}
