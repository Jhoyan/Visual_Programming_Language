using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int soma = 0;

            valor1 = Int32.Parse(txtPrimeiroValor.Text);
            valor2 = Int32.Parse(txtSegundoValor.Text);

            soma = valor1 + valor2;
            txtResultado.Text = soma.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPrimeiroValor.Clear();
            txtSegundoValor.Clear();
            txtResultado.Clear();
            txtPrimeiroValor.Focus();
        }

        private void btLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                txtPrimeiroValor.Clear();
                txtSegundoValor.Clear();
                txtResultado.Clear();
                txtPrimeiroValor.Focus();
                }
            }

        private void btLimpar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtPrimeiroValor.Clear();
                txtSegundoValor.Clear();
                txtResultado.Clear();
                txtPrimeiroValor.Focus();
            }
        }
    }
}
