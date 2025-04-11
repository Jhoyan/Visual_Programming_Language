namespace Aula02
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btAlertas = new System.Windows.Forms.Button();
            this.btExemploAlerta = new System.Windows.Forms.Button();
            this.btComboBox = new System.Windows.Forms.Button();
            this.btAlteracaoRotulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(-1, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(351, 23);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU DE OPÇÕES";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAlertas
            // 
            this.btAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlertas.Location = new System.Drawing.Point(65, 58);
            this.btAlertas.Name = "btAlertas";
            this.btAlertas.Size = new System.Drawing.Size(216, 43);
            this.btAlertas.TabIndex = 1;
            this.btAlertas.Text = "Alertas";
            this.btAlertas.UseVisualStyleBackColor = true;
            this.btAlertas.Click += new System.EventHandler(this.btAlertas_Click);
            // 
            // btExemploAlerta
            // 
            this.btExemploAlerta.BackColor = System.Drawing.Color.Tomato;
            this.btExemploAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploAlerta.Location = new System.Drawing.Point(65, 107);
            this.btExemploAlerta.Name = "btExemploAlerta";
            this.btExemploAlerta.Size = new System.Drawing.Size(216, 43);
            this.btExemploAlerta.TabIndex = 2;
            this.btExemploAlerta.Text = "Exemplo com alerta";
            this.btExemploAlerta.UseVisualStyleBackColor = false;
            this.btExemploAlerta.Click += new System.EventHandler(this.btExemploAlerta_Click);
            // 
            // btComboBox
            // 
            this.btComboBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.btComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComboBox.Location = new System.Drawing.Point(65, 205);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.Size = new System.Drawing.Size(216, 43);
            this.btComboBox.TabIndex = 3;
            this.btComboBox.Text = "Exemplo com combobox";
            this.btComboBox.UseVisualStyleBackColor = false;
            this.btComboBox.Click += new System.EventHandler(this.btComboBox_Click);
            // 
            // btAlteracaoRotulo
            // 
            this.btAlteracaoRotulo.BackColor = System.Drawing.Color.GreenYellow;
            this.btAlteracaoRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlteracaoRotulo.Location = new System.Drawing.Point(65, 156);
            this.btAlteracaoRotulo.Name = "btAlteracaoRotulo";
            this.btAlteracaoRotulo.Size = new System.Drawing.Size(216, 43);
            this.btAlteracaoRotulo.TabIndex = 4;
            this.btAlteracaoRotulo.Text = "Exemplo alteração de rótulo";
            this.btAlteracaoRotulo.UseVisualStyleBackColor = false;
            this.btAlteracaoRotulo.Click += new System.EventHandler(this.btAlteracaoRotulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 289);
            this.Controls.Add(this.btAlteracaoRotulo);
            this.Controls.Add(this.btComboBox);
            this.Controls.Add(this.btExemploAlerta);
            this.Controls.Add(this.btAlertas);
            this.Controls.Add(this.lblMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btAlertas;
        private System.Windows.Forms.Button btExemploAlerta;
        private System.Windows.Forms.Button btComboBox;
        private System.Windows.Forms.Button btAlteracaoRotulo;
    }
}

