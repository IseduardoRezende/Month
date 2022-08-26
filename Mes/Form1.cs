using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnresposta_Click(object sender, EventArgs e)
        {
            try
            {
                int letra = int.Parse(txtmes.Text);
                int revisao = int.Parse(txtmes.Text);
                if (revisao > 0 && revisao <= 12)
                {
                    int mes = int.Parse(txtmes.Text.ToString());
                    switch (mes)
                    {
                        case 1:
                            txtrespostaMes.Text = "Janeiro".ToString();
                            break;
                        case 2:
                            txtrespostaMes.Text = "Fevereiro".ToString();
                            break;
                        case 3:
                            txtrespostaMes.Text = "Março".ToString();
                            break;
                        case 4:
                            txtrespostaMes.Text = "Abril :) my Love.".ToString();
                            break;
                        case 5:
                            txtrespostaMes.Text = "Maio".ToString();
                            break;
                        case 6:
                            txtrespostaMes.Text = "Junho".ToString();
                            break;
                        case 7:
                            txtrespostaMes.Text = "Julho".ToString();
                            break;
                        case 8:
                            txtrespostaMes.Text = "Agosto".ToString();
                            break;
                        case 9:
                            txtrespostaMes.Text = "Setembro".ToString();
                            break;
                        case 10:
                            txtrespostaMes.Text = "Outubro".ToString();
                            break;
                        case 11:
                            txtrespostaMes.Text = "Novembro".ToString();
                            break;
                        case 12:
                            txtrespostaMes.Text = "Dezembro".ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Apenas números entre 1 e 12 ! ");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Caracteres não são permitidos ! ");

            }                    
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtmes.Clear();
            txtrespostaMes.Clear();
        }
    }
}
