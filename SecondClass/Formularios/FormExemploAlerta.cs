using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02.Formularios
{
    public partial class FormExemploAlerta : Form
    {
        public FormExemploAlerta()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = 0;
            double valor2 = 0;
            double resultado = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            if (valor2 == 0)
            {
                txtResultado.Text = "Não é possível dividir por zero";
            }
            else
            {
                resultado = valor1 / valor2;

                txtResultado.Text = resultado.ToString();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtResultado.Text = String.Empty;
            txtValor1.Focus();
        }
    }
}
