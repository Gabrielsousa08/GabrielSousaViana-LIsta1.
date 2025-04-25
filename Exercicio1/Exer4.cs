using System;
using System.CodeDom.Compiler;
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
    public partial class Exer4 : Form
    {
        public Exer4()
        {
            InitializeComponent();
        }
        double tempc, tempf;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tempc = Convert.ToDouble(textBox1.Text);
                tempf = (9 * tempc + 160) / 5;
                label2.Text = tempf.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Por favor, insira os vzlores válido para ah hroas trabalhadas,percentual de edesconto,valor da hora", "Erro",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
