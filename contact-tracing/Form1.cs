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
    public partial class Form1 : Form
    {

        public Form1()
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

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
