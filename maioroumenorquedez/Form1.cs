using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class FrmMaiorMenor : Form
    {
        public FrmMaiorMenor()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaiorMenor.Text, out int numero))
            {

                if (numero > 10)
                {
                    MessageBox.Show("O número é maior que 10.", "Resultado");
                }

                else if (numero < 10)
                {
                    MessageBox.Show("O número é menor que 10.", "Resultado");
                }
                else if (numero ==10)
                {
                    MessageBox.Show("Este número é o 10.", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Insira um número válido.", "Erro");
            }
            }
        }
    }