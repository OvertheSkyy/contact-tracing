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
            StreamReader inputFile = new StreamReader(@"E:\Desktop\contact-tracing\contact-tracing\contact-tracing\contacts.txt",true);
            
            savedInfoTextBox.Text = inputFile.ReadToEnd();
          
            inputFile.Close();
        }
    }
}
