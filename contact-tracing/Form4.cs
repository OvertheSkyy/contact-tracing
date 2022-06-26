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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void savedInfoTextBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void seePersonInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seePersonInfo.Text == seePersonInfo.Text)
                person1yr2021();
            
        }

        private void person1yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\" + ".txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person2yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Sherri Shah.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person3yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Rolando Doyle.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person4yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Mickey Rowland.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person5yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Ezequiel Berger.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person6yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Beatrice Morgan.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person7yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Lori Caldwell.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person8yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Eileen Burns.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person9yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Dana Love.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person10yr2021()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\Vicky Vaughan.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person1yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Cassie Mondragon.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person2yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Sherri Shah.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person3yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Rolando Doyle.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person4yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Mickey Rowland.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person5yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Ezequiel Berger.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person6yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Beatrice Morgan.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person7yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Lori Caldwell.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person8yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Eileen Burns.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person9yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Dana Love.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person10yr2022()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2022\Vicky Vaughan.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData personInfo = QR.CreateQrCode(savedInfoTextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(personInfo);
            QRGeneratePictureBox.Image = code.GetGraphic(3);
        }
    }
}
