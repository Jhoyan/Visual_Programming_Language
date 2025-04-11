using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Aula02.Formularios
{
    public partial class FormExemploComboBox : Form
    {
        public FormExemploComboBox()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoCliente = cbTipoCliente.SelectedIndex;
                double valorCompra = 0;
                double valorFinal = 0;
                if (tipoCliente >= 0 && txtValorCompra.Text != String.Empty)
                    valorCompra = Convert.ToDouble(txtValorCompra.Text);

                if (tipoCliente >= 0)
                {
                    if (valorCompra != 0 && txtValorCompra.Text != String.Empty)
                    {
                        switch (tipoCliente)
                        {
                            case 0:
                                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                                valorFinal = valorCompra * 0.75;
                                txtValorFinal.Text = valorFinal.ToString("C2");
                                break;
                            case 1:
                                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                                valorFinal = valorCompra * 0.8;
                                txtValorFinal.Text = valorFinal.ToString("C2");
                                break;
                            case 2:
                                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                                valorFinal = valorCompra * 0.85;
                                txtValorFinal.Text = valorFinal.ToString("C2");
                                break;
                            case 3:
                                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                                valorFinal = valorCompra * 0.9;
                                txtValorFinal.Text = valorFinal.ToString("C2");
                                break;
                            case 4:
                                valorCompra = Convert.ToDouble(txtValorCompra.Text);
                                valorFinal = valorCompra * 0.97;
                                txtValorFinal.Text = valorFinal.ToString("C2");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de cliente.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.FormatException) { MessageBox.Show("fodase", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void btLimpar_Click(object sender, EventArgs e)
        {
            cbTipoCliente.SelectedIndex = -1;
            txtPorcentagem.Text = String.Empty;
            txtValorCompra.Text = String.Empty;
            txtValorFinal.Text = String.Empty;
        }

        private void txtValorCompraLeave(object sender, EventArgs e)
        {

        }
    }
}
