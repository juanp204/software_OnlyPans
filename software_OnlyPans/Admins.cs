﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_OnlyPans
{
    public partial class Admins : Form
    {
        public Admins()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 cerrar = new Form1();
            cerrar.Show();
            //Form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
