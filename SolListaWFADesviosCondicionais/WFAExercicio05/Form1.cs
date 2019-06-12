using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAExercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {

            double n1, n2, n3, media, menor, maior, diferenca;

            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            n3 = Convert.ToDouble(txtN3.Text);

            String resultado = "";

            // Apresenta o menor número
            if(rbMenor.Checked)
            {
                if (n1 < n2 && n1 < n3)
                {
                    resultado = "O menor número é: " + n1;
                }
                else
                {
                    if (n2 < n3)
                    {
                        resultado = "O menor número é: " + n2;
                    }
                    else
                    {
                        resultado = "O menor número é: " + n3;
                    }
                }
                txtResultado.Text = resultado;
                // MessageBox.Show(resultado);
            }

            // Apresenta os números em ordem crescente
            if (rbOrdem.Checked)
            {
                /* Possibilidades                  
                    n1 n2 n3 
                    n1 n3 n2 
                    n2 n1 n3
                    n2 n1 n3
                    n3 n1 n2
                    n3 n2 n1
                */
                if (n1 < n2 && n1 < n3)
                {
                    if (n2 < n3)
                    {
                        resultado = n1 + " " + n2 + " " + n3;
                    }
                    else
                    {
                        resultado = n1 + " " + n3 + " " + n2;
                    }
                }
                else
                {
                    if (n2 < n1 && n2 < n3)
                    {
                        if (n1 < n3)
                        {
                            resultado = n2 + " " + n1 + " " + n3;
                        }
                        else
                        {
                            resultado = n2 + " " + n3 + " " + n1;
                        }
                    }
                    else
                    {
                        if (n1 < n2)
                        {
                            resultado = n3 + " " + n1 + " " + n2;
                        }
                        else
                        {
                            resultado = n3 + " " + n2 + " " + n1;
                        }
                    }
                }
                txtResultado.Text = resultado;
                // MessageBox.Show(resultado);
            }

            // Apresenta a média aritmética
            if (rbMedia.Checked)
            {
                media = (n1 + n2 + n3) / 3;

                txtResultado.Text = "Média: " + media;
                // MessageBox.Show("Média: " + media);
            }


            // Apresenta a diferença entre o maior e o menor número
            if (rbDiferenca.Checked)
            {
                // Encontra o maior
                if (n1 > n2 && n1 > n3)
                {
                    maior = n1;
                }
                else
                {
                    if (n2 > n3)
                    {
                        maior = n2;
                    }
                    else
                    {
                        maior = n3;
                    }
                }

                // Encontra o menor
                if (n1 < n2 && n1 < n3)
                {
                    menor = n1;
                }
                else
                {
                    if (n2 < n3)
                    {
                        menor = n2;
                    }
                    else
                    {
                        menor = n3;
                    }
                }

                diferenca = maior - menor;

                txtResultado.Text = "A diferença entre " + maior + " e " + menor + " é " + diferenca;
                //MessageBox.Show("A diferença entre " + maior + " e " + menor + " é " + diferenca);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtResultado.Text = "";
        }
    }
}
