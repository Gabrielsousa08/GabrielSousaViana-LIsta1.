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
    public partial class Exer18 : Form
    {
        public Exer18()
        {
            InitializeComponent();
        }
        double slrb, slrl;
        private void Exer18_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                slrb = Convert.ToDouble(textBox1.Text);
                slrl = slrb * 0.1;
                slrl = slrl * 0.05;
                label2.Text = slrl.ToString();
            } catch {
                MessageBox.Show("Por favor, insira os vzlores válido para ah hroas trabalhadas,percentual de edesconto,valor da hora", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
