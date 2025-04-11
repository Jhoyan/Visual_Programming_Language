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
    public partial class FormExemploAlteracaoRotulo : Form
    {
        public FormExemploAlteracaoRotulo()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado = Convert.ToDouble((txtValor1.Text.Replace("R$", "").Trim())) * ((1 + (Convert.ToDouble(txtValor2.Text.Replace("%", "").Trim())))/10);
            txtResultado.Text = resultado.ToString();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = string.Empty;
            txtValor2.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtValor1.Focus();
        }

        private void txtSalarioAtualLeave(object sender, EventArgs e)
        {
            double salario = 0;
            salario = Convert.ToDouble(txtValor1.Text);
            txtValor1.Text = salario.ToString("C2");
        }

        private void txtPorcentagemLeave(object sender, EventArgs e)
        {
            double porcentagem = 0;
            porcentagem = Convert.ToDouble(txtValor2.Text) / 100;
            txtValor2.Text = porcentagem.ToString("P2");
        }

        private void FormExemploAlteracaoRotuloKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCalcular.Select();
                btCalcular_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btLimpar_Click(sender, e);
            }
        }
    }
}
