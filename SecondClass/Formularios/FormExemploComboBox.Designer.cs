namespace Aula02.Formularios
{
    partial class FormExemploComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbTipoCliente = new System.Windows.Forms.Label();
            this.lbValorCompra = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lbPorcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.lbValorFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Cliente Diamante",
            "Cliente Ouro",
            "Cliente VIP",
            "Cliente Comum",
            "Cliente Não Frequente"});
            this.cbTipoCliente.Location = new System.Drawing.Point(43, 65);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(263, 21);
            this.cbTipoCliente.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(327, 23);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "SISTEMA DE DESCONTOS";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTipoCliente
            // 
            this.lbTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoCliente.Location = new System.Drawing.Point(12, 40);
            this.lbTipoCliente.Name = "lbTipoCliente";
            this.lbTipoCliente.Size = new System.Drawing.Size(327, 23);
            this.lbTipoCliente.TabIndex = 3;
            this.lbTipoCliente.Text = "Tipo de Cliente";
            this.lbTipoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorCompra
            // 
            this.lbValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorCompra.Location = new System.Drawing.Point(14, 94);
            this.lbValorCompra.Name = "lbValorCompra";
            this.lbValorCompra.Size = new System.Drawing.Size(327, 23);
            this.lbValorCompra.TabIndex = 4;
            this.lbValorCompra.Text = "Valor da Compra";
            this.lbValorCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(45, 117);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(263, 20);
            this.txtValorCompra.TabIndex = 5;
            this.txtValorCompra.Leave += new System.EventHandler(this.txtValorCompraLeave);
            // 
            // lbPorcentagem
            // 
            this.lbPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentagem.Location = new System.Drawing.Point(12, 145);
            this.lbPorcentagem.Name = "lbPorcentagem";
            this.lbPorcentagem.Size = new System.Drawing.Size(327, 23);
            this.lbPorcentagem.TabIndex = 6;
            this.lbPorcentagem.Text = "Porcentagem de Desconto";
            this.lbPorcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(45, 168);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(263, 20);
            this.txtPorcentagem.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(203, 222);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 16;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(72, 222);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 15;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(43, 288);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(263, 20);
            this.txtValorFinal.TabIndex = 17;
            // 
            // lbValorFinal
            // 
            this.lbValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorFinal.Location = new System.Drawing.Point(12, 262);
            this.lbValorFinal.Name = "lbValorFinal";
            this.lbValorFinal.Size = new System.Drawing.Size(327, 23);
            this.lbValorFinal.TabIndex = 18;
            this.lbValorFinal.Text = "Valor com Desconto";
            this.lbValorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExemploComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 320);
            this.Controls.Add(this.lbValorFinal);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lbPorcentagem);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.lbValorCompra);
            this.Controls.Add(this.lbTipoCliente);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.cbTipoCliente);
            this.Name = "FormExemploComboBox";
            this.Text = "FormExemploComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbTipoCliente;
        private System.Windows.Forms.Label lbValorCompra;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lbPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label lbValorFinal;
    }
}