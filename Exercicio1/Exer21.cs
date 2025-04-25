using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio1
{
    public partial class Exer21 : Form
    {
        public Exer21()
        {
            InitializeComponent();
        }
        string nome, snome, resu;
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                nome = Convert.ToString(textBox1.Text);
                snome = Convert.ToString(textBox2.Text);
                resu = nome + snome;
                label2.Text = resu.ToString();
            } catch {
                MessageBox.Show("Por favor, insira os vzlores válido para ah hroas trabalhadas,percentual de edesconto,valor da hora", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
