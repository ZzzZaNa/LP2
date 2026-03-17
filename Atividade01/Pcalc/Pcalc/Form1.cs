using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        Double numeroUm = 0;
        Double numeroDois = 0;
        Double resultante = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtprimeiroNumeroD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprimeiroNumeroD_Validating(object sender, CancelEventArgs e)
        {
            if(this.ActiveControl == btnbotaoSair)
            {
                return;
            }
            if (!double.TryParse(txtprimeiroNumeroD.Text, out double numeroUm))
            {
                MessageBox.Show("Digite um número válido para o primeiro número.");
                txtprimeiroNumeroD.Focus(); 
            }
        }

        private void txtsegundoNumeroD_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnbotaoSair)
            {
                return;
            }
            if (!double.TryParse(txtsegundoNumeroD.Text, out double numeroDois ))
            {
                MessageBox.Show("Digite um número válido para o primeiro número.");
                txtsegundoNumeroD.Focus(); 
            }
        }

        private void btnbotaoSoma_Click(object sender, EventArgs e)
        {
            resultante =  numeroUm + numeroDois;
            txtresultadoD.Text = resultante.ToString();

        }

        private void txtresultadoD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnbotaoSubtrai_Click(object sender, EventArgs e)
        {
            resultante = numeroUm - numeroDois;
            txtresultadoD.Text = resultante.ToString();
        }

        private void btnbotaoMultiplica_Click(object sender, EventArgs e)
        {
            resultante = numeroUm * numeroDois;
            txtresultadoD.Text = resultante.ToString();
        }

        private void btnbotaoDividir_Click(object sender, EventArgs e)
        {
            resultante = numeroUm / numeroDois;
            txtresultadoD.Text = resultante.ToString();
        }

        private void btnbotaoLimpar_Click(object sender, EventArgs e)
        {
            txtprimeiroNumeroD.Clear();
            txtresultadoD.Clear();
            txtsegundoNumeroD.Clear();
            numeroDois = 0;
            numeroUm = 0;
            resultante = 0;
        }

        private void btnbotaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
