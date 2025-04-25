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
    public partial class Exer2 : Form
    {
        public Exer2()
        {
            InitializeComponent();
        }
        double n1, n2, result;

        private void Exer2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            result = n1 + n2;
            label2.Text = result.ToString();
            } catch {
                MessageBox.Show("Por favor, insira os vzlores válido para ah hroas trabalhadas,percentual de edesconto,valor da hora", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
