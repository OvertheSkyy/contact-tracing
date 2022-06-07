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
    
        private void label3_Click(object sender, EventArgs e)
        {


        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
          

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string openThis = "E:\\Desktop\\contact-tracing\\contact-tracing\\contact-tracing\\COVID.mp4";
            showCovidPresent.Text = openThis;
            axWindowsMediaPlayer1.URL = showCovidPresent.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
