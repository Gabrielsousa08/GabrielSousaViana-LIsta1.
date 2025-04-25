using System;
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
    public partial class Exer9 : Form
    {
        public Exer9()
        {
            InitializeComponent();
        }

        double a, b, c, d, aaB, aac, aad, bac, bad, cad, amb, amc, amd, bmc, bmd, cmd;

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);
            aaB = a * b;
            aac = a * c;
            aad = a * d;
            bac = b * c;
            bad = b * d;
            cad = c * d;
            amb = a + b;
            amc = a + c;
            amd = a + d;
            bmc = b + c;
            bmd = b + d;
            cmd = c + d;
            label12.Text = amb.ToString();
            label13.Text = amc.ToString();
            label20.Text = amd.ToString();
            label21.Text = bmc.ToString();
            label22.Text = bmd.ToString();
            label26.Text = cmd.ToString();
            label29.Text = aaB.ToString();
            label28.Text = aac.ToString();
            label27.Text = aad.ToString();
            label23.Text = bac.ToString();
            label24.Text = bad.ToString();
            label25.Text = cad.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exer9_Load(object sender, EventArgs e)
        {
           

        }
    }
}
