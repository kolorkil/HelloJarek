﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloJarek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cześć Jarek!", "Witaj");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cześć Karol!", "Witaj");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cześć Andrzej!", "Witaj");
        }
    }
}
