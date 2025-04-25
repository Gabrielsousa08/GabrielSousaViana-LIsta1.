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
    public partial class Exer17 : Form
    {
        public Exer17()
        {
            InitializeComponent();
        }
        int n1, n2, q, rd;
        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);    
            q = n1 / n2;
            rd = n1 % n2;
            label2.Text = q.ToString();
            label7.Text = rd.ToString();
        }
    }
}
