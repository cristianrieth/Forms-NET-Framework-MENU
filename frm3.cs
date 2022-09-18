using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_1
{
    
    public partial class frm3 : Form
        
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            cbxEscolha.Text = "";
            txtvelocidade.Clear();
            lblvelocidade.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double veloc = 0, resul = 0;
            if (txtvelocidade.Text != "")
            {
                veloc = double.Parse(txtvelocidade.Text);
            }
            else 
            { 
                MessageBox.Show("Informe a Velocidade.", "Velociadde", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            if (cbxEscolha.Text == "m/s")
            {
                resul = veloc / 3.6;
                lblvelocidade.Text = (veloc + "km/h é igual à: " + Math.Round(resul, 2) + cbxEscolha.Text);
            }
            else if (cbxEscolha.Text == "km/h")
            {
                resul = veloc * 3.6;
                lblvelocidade.Text = (veloc + "m/s é igual à: " + Math.Round(resul, 2) + cbxEscolha.Text);
            }
            else
            {
                MessageBox.Show("Informe a unidade de conversão.", "Velociadde", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtvelocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
