using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio1
{
    public partial class Exer7 : Form
    {
        public Exer7()
        {
            InitializeComponent();
        }
        double vel, temp, dist, ltr_usa;
        private void Exer7_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBox1.Text);
            vel = Convert.ToDouble(textBox2.Text);
            dist = temp * vel;
            ltr_usa = dist / 12;
            label2.Text = vel.ToString();
            label7.Text = temp.ToString();
            label8.Text = dist.ToString();
            label10.Text = ltr_usa.ToString();

        }
    }
}
