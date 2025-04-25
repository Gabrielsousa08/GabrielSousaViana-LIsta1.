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
    public partial class Exer3 : Form
    {
        public Exer3()
        {
            InitializeComponent();
        }
        double hrs_trb, per_desc, vlr_hora, slr_brt, slr_liquido;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hrs_trb = Convert.ToDouble(textBox1.Text);
                per_desc = Convert.ToDouble(textBox3.Text);
                vlr_hora = Convert.ToDouble(textBox2.Text);
                slr_brt = vlr_hora * hrs_trb;
                per_desc = (per_desc / 100) * slr_brt;
                slr_liquido = slr_brt - per_desc;
                label2.Text = slr_liquido.ToString("F2");
            } catch {
                MessageBox.Show("Por favor, insira os vzlores válido para ah hroas trabalhadas,percentual de edesconto,valor da hora", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exer3_Load(object sender, EventArgs e)
        {

        }
    }
}
