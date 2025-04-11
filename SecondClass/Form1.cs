using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula02.Formularios;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAlertas_Click(object sender, EventArgs e)
        {
            FormAlertas formAlertas = new FormAlertas();
            formAlertas.ShowDialog();
        }

        private void btAlteracaoRotulo_Click(object sender, EventArgs e)
        {
            FormExemploAlteracaoRotulo formExemploAlteracaoRotulo = new FormExemploAlteracaoRotulo();
            formExemploAlteracaoRotulo.ShowDialog();
        }

        private void btExemploAlerta_Click(object sender, EventArgs e)
        {

        }

        private void btComboBox_Click(object sender, EventArgs e)
        {
            FormExemploComboBox formExemploComboBox = new FormExemploComboBox();
            formExemploComboBox.ShowDialog();
        }
    }
}
