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
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace contact_tracing
{
    public partial class personalInfoForm : Form
    {
        private Thread thread;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        public personalInfoForm()
        {
            InitializeComponent();
        }

        private void nameOfCamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void infoOfQRCodeRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                nameOfCamComboBox.Items.Add(filterInfo.Name);
            nameOfCamComboBox.SelectedIndex = 0;
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
            sexSelectionComboBox.Text = "";
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
            if (yearOfCreationComboBox.Text == "2019")
            {
                string personFilePath = @"E:\Desktop\contact-tracing\2019\" + lastNameTextBox.Text + "," + firstNameTextBox.Text + ".txt";

                StreamWriter outputFile = new StreamWriter(personFilePath);
                using (outputFile)
                {
                    outputFile.WriteLine(personInfoLabel.Text);
                    outputFile.WriteLine(nameLabel.Text);
                    outputFile.WriteLine(lastNameTextBox.Text);
                    outputFile.WriteLine(firstNameTextBox.Text);
                    outputFile.WriteLine(middleInitialTextBox.Text);
                    outputFile.WriteLine(addressTextBox.Text);
                    outputFile.WriteLine(dateOfBirthLabel.Text);
                    outputFile.WriteLine(dateOfBirthTextBox.Text);
                    outputFile.WriteLine(ageLabel.Text);
                    outputFile.WriteLine(ageTextBox.Text);
                    outputFile.WriteLine(sexLabel.Text);
                    outputFile.WriteLine(sexSelectionComboBox.Text);
                    outputFile.WriteLine(contactNoLabel.Text);
                    outputFile.WriteLine(contactNoTextBox.Text);
                    outputFile.WriteLine(healthFormLabel.Text);
                    outputFile.WriteLine(firstDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox1.Text);
                    outputFile.WriteLine(firstDoseDate.Text);
                    outputFile.WriteLine(firstDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandTextBox1.Text);
                    outputFile.WriteLine(secondDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox2.Text);
                    outputFile.WriteLine(secondDoseDate.Text);
                    outputFile.WriteLine(secondDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandLabel2.Text);
                    outputFile.WriteLine(vaccineBrandTextBox2.Text);
                    outputFile.WriteLine(boosterShotsLabel.Text);
                    outputFile.WriteLine(answerTextBox3.Text);
                    outputFile.WriteLine(dateTodayLabel.Text);
                    outputFile.WriteLine(monthOfCreationComboBox.Text);
                    outputFile.WriteLine(dayOfCreationComboBox.Text);
                    outputFile.WriteLine(yearOfCreationComboBox.Text);

                    outputFile.Close();
                }
            }
            else if (yearOfCreationComboBox.Text == "2020")
            {
                string personFilePath = @"E:\Desktop\contact-tracing\2020\" + lastNameTextBox.Text + "," + firstNameTextBox.Text + ".txt";

                StreamWriter outputFile = new StreamWriter(personFilePath);
                using (outputFile)
                {
                    outputFile.WriteLine(personInfoLabel.Text);
                    outputFile.WriteLine(nameLabel.Text);
                    outputFile.WriteLine(lastNameTextBox.Text);
                    outputFile.WriteLine(firstNameTextBox.Text);
                    outputFile.WriteLine(middleInitialTextBox.Text);
                    outputFile.WriteLine(addressTextBox.Text);
                    outputFile.WriteLine(dateOfBirthLabel.Text);
                    outputFile.WriteLine(dateOfBirthTextBox.Text);
                    outputFile.WriteLine(ageLabel.Text);
                    outputFile.WriteLine(ageTextBox.Text);
                    outputFile.WriteLine(sexLabel.Text);
                    outputFile.WriteLine(sexSelectionComboBox.Text);
                    outputFile.WriteLine(contactNoLabel.Text);
                    outputFile.WriteLine(contactNoTextBox.Text);
                    outputFile.WriteLine(healthFormLabel.Text);
                    outputFile.WriteLine(firstDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox1.Text);
                    outputFile.WriteLine(firstDoseDate.Text);
                    outputFile.WriteLine(firstDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandTextBox1.Text);
                    outputFile.WriteLine(secondDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox2.Text);
                    outputFile.WriteLine(secondDoseDate.Text);
                    outputFile.WriteLine(secondDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandLabel2.Text);
                    outputFile.WriteLine(vaccineBrandTextBox2.Text);
                    outputFile.WriteLine(boosterShotsLabel.Text);
                    outputFile.WriteLine(answerTextBox3.Text);
                    outputFile.WriteLine(dateTodayLabel.Text);
                    outputFile.WriteLine(monthOfCreationComboBox.Text);
                    outputFile.WriteLine(dayOfCreationComboBox.Text);
                    outputFile.WriteLine(yearOfCreationComboBox.Text);

                    outputFile.Close();
                }
            }
            else if (yearOfCreationComboBox.Text == "2021")
            {
                string personFilePath = @"E:\Desktop\contact-tracing\2021\" + lastNameTextBox.Text + "," + firstNameTextBox.Text + ".txt";

                StreamWriter outputFile = new StreamWriter(personFilePath);
                using (outputFile)
                {
                    outputFile.WriteLine(personInfoLabel.Text);
                    outputFile.WriteLine(nameLabel.Text);
                    outputFile.WriteLine(lastNameTextBox.Text);
                    outputFile.WriteLine(firstNameTextBox.Text);
                    outputFile.WriteLine(middleInitialTextBox.Text);
                    outputFile.WriteLine(addressTextBox.Text);
                    outputFile.WriteLine(dateOfBirthLabel.Text);
                    outputFile.WriteLine(dateOfBirthTextBox.Text);
                    outputFile.WriteLine(ageLabel.Text);
                    outputFile.WriteLine(ageTextBox.Text);
                    outputFile.WriteLine(sexLabel.Text);
                    outputFile.WriteLine(sexSelectionComboBox.Text);
                    outputFile.WriteLine(contactNoLabel.Text);
                    outputFile.WriteLine(contactNoTextBox.Text);
                    outputFile.WriteLine(healthFormLabel.Text);
                    outputFile.WriteLine(firstDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox1.Text);
                    outputFile.WriteLine(firstDoseDate.Text);
                    outputFile.WriteLine(firstDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandTextBox1.Text);
                    outputFile.WriteLine(secondDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox2.Text);
                    outputFile.WriteLine(secondDoseDate.Text);
                    outputFile.WriteLine(secondDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandLabel2.Text);
                    outputFile.WriteLine(vaccineBrandTextBox2.Text);
                    outputFile.WriteLine(boosterShotsLabel.Text);
                    outputFile.WriteLine(answerTextBox3.Text);
                    outputFile.WriteLine(dateTodayLabel.Text);
                    outputFile.WriteLine(monthOfCreationComboBox.Text);
                    outputFile.WriteLine(dayOfCreationComboBox.Text);
                    outputFile.WriteLine(yearOfCreationComboBox.Text);

                    outputFile.Close();
                }
            }
            else if (yearOfCreationComboBox.Text == "2022")
            {
                string personFilePath = @"E:\Desktop\contact-tracing\2022\" + lastNameTextBox.Text + "," + firstNameTextBox.Text + ".txt";

                StreamWriter outputFile = new StreamWriter(personFilePath);
                using (outputFile)
                {
                    outputFile.WriteLine(personInfoLabel.Text);
                    outputFile.WriteLine(nameLabel.Text);
                    outputFile.WriteLine(lastNameTextBox.Text);
                    outputFile.WriteLine(firstNameTextBox.Text);
                    outputFile.WriteLine(middleInitialTextBox.Text);
                    outputFile.WriteLine(addressTextBox.Text);
                    outputFile.WriteLine(dateOfBirthLabel.Text);
                    outputFile.WriteLine(dateOfBirthTextBox.Text);
                    outputFile.WriteLine(ageLabel.Text);
                    outputFile.WriteLine(ageTextBox.Text);
                    outputFile.WriteLine(sexLabel.Text);
                    outputFile.WriteLine(sexSelectionComboBox.Text);
                    outputFile.WriteLine(contactNoLabel.Text);
                    outputFile.WriteLine(contactNoTextBox.Text);
                    outputFile.WriteLine(healthFormLabel.Text);
                    outputFile.WriteLine(firstDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox1.Text);
                    outputFile.WriteLine(firstDoseDate.Text);
                    outputFile.WriteLine(firstDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandTextBox1.Text);
                    outputFile.WriteLine(secondDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox2.Text);
                    outputFile.WriteLine(secondDoseDate.Text);
                    outputFile.WriteLine(secondDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandLabel2.Text);
                    outputFile.WriteLine(vaccineBrandTextBox2.Text);
                    outputFile.WriteLine(boosterShotsLabel.Text);
                    outputFile.WriteLine(answerTextBox3.Text);
                    outputFile.WriteLine(dateTodayLabel.Text);
                    outputFile.WriteLine(monthOfCreationComboBox.Text);
                    outputFile.WriteLine(dayOfCreationComboBox.Text);
                    outputFile.WriteLine(yearOfCreationComboBox.Text);

                    outputFile.Close();
                }
            }
            else if (yearOfCreationComboBox.Text == "2023")
            {
                string personFilePath = @"E:\Desktop\contact-tracing\2023\" + lastNameTextBox.Text + "," + firstNameTextBox.Text + ".txt";

                StreamWriter outputFile = new StreamWriter(personFilePath);
                using (outputFile)
                {
                    outputFile.WriteLine(personInfoLabel.Text);
                    outputFile.WriteLine(nameLabel.Text);
                    outputFile.WriteLine(lastNameTextBox.Text);
                    outputFile.WriteLine(firstNameTextBox.Text);
                    outputFile.WriteLine(middleInitialTextBox.Text);
                    outputFile.WriteLine(addressTextBox.Text);
                    outputFile.WriteLine(dateOfBirthLabel.Text);
                    outputFile.WriteLine(dateOfBirthTextBox.Text);
                    outputFile.WriteLine(ageLabel.Text);
                    outputFile.WriteLine(ageTextBox.Text);
                    outputFile.WriteLine(sexLabel.Text);
                    outputFile.WriteLine(sexSelectionComboBox.Text);
                    outputFile.WriteLine(contactNoLabel.Text);
                    outputFile.WriteLine(contactNoTextBox.Text);
                    outputFile.WriteLine(healthFormLabel.Text);
                    outputFile.WriteLine(firstDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox1.Text);
                    outputFile.WriteLine(firstDoseDate.Text);
                    outputFile.WriteLine(firstDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandTextBox1.Text);
                    outputFile.WriteLine(secondDoseLabel.Text);
                    outputFile.WriteLine(answerTextBox2.Text);
                    outputFile.WriteLine(secondDoseDate.Text);
                    outputFile.WriteLine(secondDoseDateTextBox.Text);
                    outputFile.WriteLine(vaccineBrandLabel2.Text);
                    outputFile.WriteLine(vaccineBrandTextBox2.Text);
                    outputFile.WriteLine(boosterShotsLabel.Text);
                    outputFile.WriteLine(answerTextBox3.Text);
                    outputFile.WriteLine(dateTodayLabel.Text);
                    outputFile.WriteLine(monthOfCreationComboBox.Text);
                    outputFile.WriteLine(dayOfCreationComboBox.Text);
                    outputFile.WriteLine(yearOfCreationComboBox.Text);

                    outputFile.Close();
                }
            }
        }

        private void checkInfoBtn_Click(object sender, EventArgs e)
        {
            thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openNewForm()
        {
            Application.Run(new checkInfoForm());
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
            sexSelectionComboBox.Text = "";
            contactNoTextBox.Text = "";
            answerTextBox1.Text = "";
            firstDoseDateTextBox.Text = "";
            vaccineBrandTextBox1.Text = "";
            answerTextBox2.Text = "";
            secondDoseDateTextBox.Text = "";
            vaccineBrandTextBox2.Text = "";
            answerTextBox3.Text = "";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(backToLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void backToLoginForm()
        {
            Application.Run(new loginForm());
        }

        private void readQRCodeBtn_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[nameOfCamComboBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += capturingQRCode_NewFrame;
            videoCaptureDevice.Start();
            capturingQRTimer.Start();
        }

        private void capturingQRCode_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            capturingQRDevice.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void personalInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        private void capturingQRTimer_Tick(object sender, EventArgs e)
        {
            if (capturingQRDevice.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)capturingQRDevice.Image);
                if (result != null)
                {
                    infoOfQRCodeRTB.Text = result.ToString();
                    capturingQRTimer.Stop();
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                }
            }
        }

        private void autoFillBtn_Click(object sender, EventArgs e)
        {
            string[] readQRInfo = infoOfQRCodeRTB.Lines;

                lastNameTextBox.Text = readQRInfo[2];
                firstNameTextBox.Text = readQRInfo[3];
                middleInitialTextBox.Text = readQRInfo[4];
                addressTextBox.Text = readQRInfo[5];
                dateOfBirthTextBox.Text = readQRInfo[7];
                ageTextBox.Text = readQRInfo[9];
                sexSelectionComboBox.Text = readQRInfo[11];
                contactNoTextBox.Text = readQRInfo[13];

                if (readQRInfo[16] == "Yes")
                {
                    firstDoseYes.Checked = true;
                }
                else if (readQRInfo[16] == "No")
                { 
                    firstDoseNo.Checked = true;
                }
                answerTextBox1.Text = readQRInfo[16];
                
                firstDoseDateTextBox.Text = readQRInfo[18];
                vaccineBrandTextBox1.Text = readQRInfo[19];
                answerTextBox2.Text = readQRInfo[21];
                if (readQRInfo[21] == "Yes")
                {
                    secondDoseYes.Checked = true;
                }
                else if (readQRInfo[21] == "No")
                {
                    secondDoseNo.Checked = true;
                }

                secondDoseDateTextBox.Text = readQRInfo[23];
                vaccineBrandTextBox2.Text = readQRInfo[25];
                answerTextBox3.Text = readQRInfo[27];
                monthOfCreationComboBox.Text = readQRInfo[29];
                dayOfCreationComboBox.Text = readQRInfo[30];
                yearOfCreationComboBox.Text = readQRInfo[31];

        }
    }
}
