﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Exer10 : Form
    {
        public Exer10()
        {
            InitializeComponent();
        }
        double comp, larg, alt, vol;
        private void Exer10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comp = Convert.ToDouble(textBox1.Text);
            larg = Convert.ToDouble(textBox2.Text);
            alt = Convert.ToDouble(textBox3.Text);
            vol = comp * larg * alt;
            label2.Text = comp.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
