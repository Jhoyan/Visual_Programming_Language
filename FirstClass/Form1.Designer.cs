namespace PrimeiraAula
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSoma = new System.Windows.Forms.Button();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(349, 163);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(75, 23);
            this.btSoma.TabIndex = 0;
            this.btSoma.Text = "SOMAR";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.AcceptsTab = true;
            this.txtSegundoValor.Location = new System.Drawing.Point(336, 128);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoValor.TabIndex = 1;
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.AcceptsTab = true;
            this.txtPrimeiroValor.Location = new System.Drawing.Point(336, 79);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiroValor.TabIndex = 2;
            this.txtPrimeiroValor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soma de dois valores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(350, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 15);
            this.label.TabIndex = 5;
            this.label.Text = "Primeiro valor";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(350, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            this.txtResultado.AcceptsTab = true;
            this.txtResultado.Location = new System.Drawing.Point(336, 215);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(353, 246);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.btSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btLimpar;
    }
}

