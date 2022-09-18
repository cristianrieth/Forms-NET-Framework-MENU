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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtr1.Clear();
            lblr1.Text = "";
            txtr2.Clear();
            lblr2.Text = "";
            txtr3.Clear();
            lblr3.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double r1 = 0, r2 = 0, r3 = 0, t1 = 0, t2 = 0, t3 = 0;

            try
            {
              
                    r1 = double.Parse(txtr1.Text);
                    r2 = double.Parse(txtr2.Text);
                    r3 = double.Parse(txtr3.Text);

                    t1 = (1 / (Math.Pow(298.15, -1) + Math.Pow(3950, -1) * Math.Log10(r1 / 10000))) - 273.15;
                    t2 = (1 / (Math.Pow(298.15, -1) + Math.Pow(3950, -1) * Math.Log10(r2 / 10000))) - 273.15;
                    t3 = (1 / (Math.Pow(298.15, -1) + Math.Pow(3950, -1) * Math.Log10(r3 / 10000))) - 273.15;

                    lblr1.Text = (Math.Round(t1, 2) + "ºC");
                    lblr2.Text = (Math.Round(t2, 2) + "ºC");
                    lblr3.Text = (Math.Round(t3, 2) + "ºC");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Informe todas as resistências.", "Termístores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtr3_KeyPress(object sender, KeyPressEventArgs e)
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
