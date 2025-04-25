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
    public partial class Exer14 : Form
    {
        public Exer14()
        {
            InitializeComponent();
        }
        double v1, v2, result;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);
            result = (v1 + v2) / 2;
            label2.Text = result.ToString();
        }
    }
}
