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

        private void seePersonInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seePersonInfo.Text == "Cassie Mondragon")
                person1();
            else if (seePersonInfo.Text == "Sherri Shah")
                person2();
            else if (seePersonInfo.Text == "Rolando Doyle")
                person3();
            else if (seePersonInfo.Text == "Mickey Rowland")
                person4();
            else if (seePersonInfo.Text == "Ezequiel Berger")
                person5();
            else if (seePersonInfo.Text == "Beatrice Morgan")
                person6();
            else if (seePersonInfo.Text == "Lori Caldwell")
                person7();
            else if (seePersonInfo.Text == "Eileen Burns")
                person8();
            else if (seePersonInfo.Text == "Dana Love")
                person9();
            else if (seePersonInfo.Text == "Vicky Vaughan")
                person10();
        }

        private void person1()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Cassie Mondragon.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person2()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Sherri Shah.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person3()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Rolando Doyle.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person4()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Mickey Rowland.txt");

            savedInfoTextBox.Text = inputFile.ReadToEnd();

            inputFile.Close();
        }

        private void person5()
        {
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\Ezequiel Berger.txt");

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
