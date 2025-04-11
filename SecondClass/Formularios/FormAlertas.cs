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
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }

        private void btInformacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTÃO TOMA ESSA INFORMAÇÃO NA SUA CARA", "INFORMAÇÃO QUE VC PRECISA SABER:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TENHA ATENÇÃO COM O QUE ESTÁ FAZENDO AGORA", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOCÊ ESTÁ TENTANDO FAZER ALGO QUE NÃO É SUPORTADO", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("TEM CERTEZA QUE DESEJA FAZER ISSO?", "PERGUNTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("A resposta foi sim!", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A resposta foi não!","Resposta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btExemplo_Click(object sender, EventArgs e)
        {
            FormExemploAlerta formExemploAlerta = new FormExemploAlerta();
            formExemploAlerta.ShowDialog();
        }
    }
}
