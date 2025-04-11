namespace Aula02.Formularios
{
    partial class FormAlertas
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
            this.btErro = new System.Windows.Forms.Button();
            this.btPergunta = new System.Windows.Forms.Button();
            this.btAtencao = new System.Windows.Forms.Button();
            this.btInformacao = new System.Windows.Forms.Button();
            this.btExemplo = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btErro
            // 
            this.btErro.BackColor = System.Drawing.Color.Red;
            this.btErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btErro.Location = new System.Drawing.Point(70, 162);
            this.btErro.Name = "btErro";
            this.btErro.Size = new System.Drawing.Size(216, 43);
            this.btErro.TabIndex = 8;
            this.btErro.Text = "Erro";
            this.btErro.UseVisualStyleBackColor = false;
            this.btErro.Click += new System.EventHandler(this.btErro_Click);
            // 
            // btPergunta
            // 
            this.btPergunta.BackColor = System.Drawing.Color.Lime;
            this.btPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPergunta.Location = new System.Drawing.Point(70, 211);
            this.btPergunta.Name = "btPergunta";
            this.btPergunta.Size = new System.Drawing.Size(216, 43);
            this.btPergunta.TabIndex = 7;
            this.btPergunta.Text = "Pergunta";
            this.btPergunta.UseVisualStyleBackColor = false;
            this.btPergunta.Click += new System.EventHandler(this.btPergunta_Click);
            // 
            // btAtencao
            // 
            this.btAtencao.BackColor = System.Drawing.Color.DarkOrange;
            this.btAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtencao.Location = new System.Drawing.Point(70, 113);
            this.btAtencao.Name = "btAtencao";
            this.btAtencao.Size = new System.Drawing.Size(216, 43);
            this.btAtencao.TabIndex = 6;
            this.btAtencao.Text = "Atenção";
            this.btAtencao.UseVisualStyleBackColor = false;
            this.btAtencao.Click += new System.EventHandler(this.btAtencao_Click);
            // 
            // btInformacao
            // 
            this.btInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInformacao.Location = new System.Drawing.Point(70, 64);
            this.btInformacao.Name = "btInformacao";
            this.btInformacao.Size = new System.Drawing.Size(216, 43);
            this.btInformacao.TabIndex = 5;
            this.btInformacao.Text = "Informação";
            this.btInformacao.UseVisualStyleBackColor = true;
            this.btInformacao.Click += new System.EventHandler(this.btInformacao_Click);
            // 
            // btExemplo
            // 
            this.btExemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemplo.Location = new System.Drawing.Point(70, 260);
            this.btExemplo.Name = "btExemplo";
            this.btExemplo.Size = new System.Drawing.Size(216, 43);
            this.btExemplo.TabIndex = 9;
            this.btExemplo.Text = "Exemplo";
            this.btExemplo.UseVisualStyleBackColor = true;
            this.btExemplo.Click += new System.EventHandler(this.btExemplo_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(0, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(351, 52);
            this.lblMenu.TabIndex = 10;
            this.lblMenu.Text = "Alertas de interação com o usuário";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 320);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btExemplo);
            this.Controls.Add(this.btErro);
            this.Controls.Add(this.btPergunta);
            this.Controls.Add(this.btAtencao);
            this.Controls.Add(this.btInformacao);
            this.Name = "FormAlertas";
            this.Text = "FormAlertas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btErro;
        private System.Windows.Forms.Button btPergunta;
        private System.Windows.Forms.Button btAtencao;
        private System.Windows.Forms.Button btInformacao;
        private System.Windows.Forms.Button btExemplo;
        private System.Windows.Forms.Label lblMenu;
    }
}