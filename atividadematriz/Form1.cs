using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadematriz
{
    public partial class Form1 : Form
    {

        int[,] matriz = new int[3, 3] //Declaração da matriz bidimensional
    {
               { 1, 5, -2 },
               { 8, 3, 0  },
               { 4, -1, 2 }
    };

        int i = 0; //Número de linhas
        int j = 0; //Número de colunas

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMatriz_Click(object sender, EventArgs e)
        {
            txtExibir.Clear(); // Limpa a textbox, Impossibilitando a exibição da mesma matriz ao precissonar o botão novamente

            for (i = 0; i <= 2; i++) //laço for para linhas, começa pelo indice 0 á 2.
            {
                for (j = 0; j <= 2; j++) //laço for para colunas
                {
                    txtExibir.Text += matriz[i, j].ToString() + " "; //Converte para string para ser exibido na textbox
                }
                txtExibir.Text += Environment.NewLine; //Quebra a linha 
            }
        }

        private void btnExibirMaior_Click(object sender, EventArgs e)
        {
          
            int maiorValor = matriz[0, 0]; //Variável que vai buscar o maior valor dentro da matriz

            foreach (int valor in matriz) //Variável que irá armazenar o maior valor da matriz
            {
                if (valor > maiorValor) 
                {
                    maiorValor = valor;
                }
            }

            MessageBox.Show("Maior valor: " + maiorValor.ToString(), "Resultado");
        }
    }
    }
