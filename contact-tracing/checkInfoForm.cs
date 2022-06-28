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
    public partial class checkInfoForm : Form
    {
        
        public checkInfoForm()
        {
            InitializeComponent();
        }

        private void generateQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData personInfo = QR.CreateQrCode(savedInfoRichTextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(personInfo);
            generatedQRPictureBox.Image = code.GetGraphic(3);
        }

        private void showNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personalInfoForm form = new personalInfoForm();
            form.Hide();
            this.Close();
        }

        private void dateOfCreation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateOfCreation.Text == "2019")
            {
                dateOfCreationyr2019();
            }

            else if (dateOfCreation.Text == "2020")
            {
                dateOfCreationyr2020();
            }

            else if (dateOfCreation.Text == "2021")
            {
                dateOfCreationyr2021();
            }

            else if (dateOfCreation.Text == "2022")
            {
                dateOfCreationyr2022();
            }

            else if (dateOfCreation.Text == "2023")
            {
                dateOfCreationyr2023();
            }
        }

        private void dateOfCreationyr2019()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\contact-tracing\2019\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void dateOfCreationyr2020()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\contact-tracing\2020\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void dateOfCreationyr2021()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\contact-tracing\2021\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void dateOfCreationyr2022()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\contact-tracing\2022\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void dateOfCreationyr2023()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\contact-tracing\2023\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void seePersonInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string personFilePath = seePersonInfoComboBox.SelectedItem as string;
            StreamReader readFilePath = new StreamReader(personFilePath);
           
            savedInfoRichTextBox.Text = readFilePath.ReadToEnd();

        }

        private void savedInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
