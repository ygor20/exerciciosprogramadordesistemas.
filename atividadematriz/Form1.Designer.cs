
namespace atividadematriz
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.btnExibirMaior = new System.Windows.Forms.Button();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Teal;
            this.panelFundo.Controls.Add(this.btnExibirMaior);
            this.panelFundo.Controls.Add(this.txtExibir);
            this.panelFundo.Controls.Add(this.btnMostrarMatriz);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(556, 414);
            this.panelFundo.TabIndex = 0;
            // 
            // btnExibirMaior
            // 
            this.btnExibirMaior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExibirMaior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirMaior.ForeColor = System.Drawing.Color.White;
            this.btnExibirMaior.Location = new System.Drawing.Point(201, 276);
            this.btnExibirMaior.Name = "btnExibirMaior";
            this.btnExibirMaior.Size = new System.Drawing.Size(186, 58);
            this.btnExibirMaior.TabIndex = 4;
            this.btnExibirMaior.Text = "Exibir Maior Valor";
            this.btnExibirMaior.UseVisualStyleBackColor = false;
            this.btnExibirMaior.Click += new System.EventHandler(this.btnExibirMaior_Click);
            // 
            // txtExibir
            // 
            this.txtExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExibir.Location = new System.Drawing.Point(201, 112);
            this.txtExibir.Multiline = true;
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(186, 143);
            this.txtExibir.TabIndex = 3;
            this.txtExibir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMatriz.ForeColor = System.Drawing.Color.White;
            this.btnMostrarMatriz.Location = new System.Drawing.Point(201, 28);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(186, 63);
            this.btnMostrarMatriz.TabIndex = 2;
            this.btnMostrarMatriz.Text = "Mostrar Matriz";
            this.btnMostrarMatriz.UseVisualStyleBackColor = false;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.btnMostrarMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 414);
            this.Controls.Add(this.panelFundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.Button btnExibirMaior;
    }
}

