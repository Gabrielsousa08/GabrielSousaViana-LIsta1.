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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio1
{
    public partial class Exer19 : Form
    {
        public Exer19()
        {
            InitializeComponent();
        }
        double vel, temp, dist, ltr_usa;
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
                temp = Convert.ToDouble(textBox1.Text);
                vel = Convert.ToDouble(textBox2.Text);
                dist = temp * vel;
                ltr_usa = dist / 12;
                label2.Text = vel.ToString();
            } catch
            {
                MessageBox.Show("Por favor, insira os vzlores válido para ah hroas trabalhadas,percentual de edesconto,valor da hora", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
