﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         Calculations calculations = new Calculations();
         textBox3.Text=calculations.sum(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text)).ToString();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculations calculations = new Calculations();
            textBox3.Text = calculations.subtract(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
