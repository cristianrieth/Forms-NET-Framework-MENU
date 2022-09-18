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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 Termistor = new frm2();
            Termistor.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resp = MessageBox.Show("Deseja mesmo sair?", "Calcular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 Conversao = new frm3();
            Conversao.ShowDialog();
        }

        private void quantidadeDeÁguaEValorASerPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm4 agua = new frm4();
            agua.ShowDialog();
        }
    }
}
