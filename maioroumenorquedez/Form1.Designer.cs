
namespace maioroumenorquedez
{
    partial class FrmMaiorMenor
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
            this.lblDigite = new System.Windows.Forms.Label();
            this.txtMaiorMenor = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigite.Location = new System.Drawing.Point(23, 9);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(463, 29);
            this.lblDigite.TabIndex = 0;
            this.lblDigite.Text = "Digite um número maior ou menor que 10:";
            // 
            // txtMaiorMenor
            // 
            this.txtMaiorMenor.Location = new System.Drawing.Point(175, 61);
            this.txtMaiorMenor.Name = "txtMaiorMenor";
            this.txtMaiorMenor.Size = new System.Drawing.Size(143, 20);
            this.txtMaiorMenor.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Turquoise;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(196, 87);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(94, 35);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // FrmMaiorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 124);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtMaiorMenor);
            this.Controls.Add(this.lblDigite);
            this.Name = "FrmMaiorMenor";
            this.Text = "Maior ou Menor Que Dez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.TextBox txtMaiorMenor;
        private System.Windows.Forms.Button btnVerificar;
    }
}

