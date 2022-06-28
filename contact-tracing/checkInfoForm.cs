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
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\2021\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personalInfoForm form = new personalInfoForm();
            form.Hide();
            this.Close();
        }

    }
}
