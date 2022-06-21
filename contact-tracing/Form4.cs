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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void savedInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showInfoBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void person1()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Cassie Mondragon.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person2()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Sherri Shah.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person3()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Rolando Doyle.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person4()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Mickey Rowland.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }
        
        private void person5()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Ezequiel Berger.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person6()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Beatrice Morgan.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person7()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Lori Caldwell.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person8()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Eileen Burns.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person9()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Dana Love.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person10()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Vicky Vaughan.txt", true);

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }
    }
}
