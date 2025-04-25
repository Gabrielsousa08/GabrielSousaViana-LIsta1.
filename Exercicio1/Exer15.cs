using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Exer15 : Form
    {
        public Exer15()
        {
            InitializeComponent();
        }
        double n1, n2, n11, n22;
        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n11 = n1;
            n22 = n2;
            label2.Text = n22.ToString();
            label7.Text = n11.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
