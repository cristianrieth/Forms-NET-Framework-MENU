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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlitros.Clear();
            lblvalor.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double litros = 0, valor = 0, pagar =0;
            if (txtlitros.Text != "")
            {
                litros = double.Parse(txtlitros.Text);
            }
            else
            {
                MessageBox.Show("Informe a quantidade de litros.", "Conta de água", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           if (litros > 8000)
                {
                valor = litros - 8000;
                pagar = (valor * 0.00854) + 28.50;
                lblvalor.Text = ("O total a pagar é de: R$" + Math.Round(pagar, 2));
                }
           else
            {
                lblvalor.Text = ("O total a pagar é de: R$28,50");
            }

        }

        private void txtlitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsNumber (e.KeyChar) && !char.IsPunctuation(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
