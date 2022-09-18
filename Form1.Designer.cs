namespace Desafio_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imcToolStripMenuItem
            // 
            this.imcToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.imcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem,
            this.bbToolStripMenuItem,
            this.ccToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.imcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imcToolStripMenuItem.Name = "imcToolStripMenuItem";
            this.imcToolStripMenuItem.Size = new System.Drawing.Size(84, 45);
            this.imcToolStripMenuItem.Text = "Calcular";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(434, 26);
            this.aaToolStripMenuItem.Text = "Temperatura em graus Celsius de um termístor";
            this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click);
            // 
            // bbToolStripMenuItem
            // 
            this.bbToolStripMenuItem.Name = "bbToolStripMenuItem";
            this.bbToolStripMenuItem.Size = new System.Drawing.Size(431, 6);
            // 
            // ccToolStripMenuItem
            // 
            this.ccToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ccToolStripMenuItem.Name = "ccToolStripMenuItem";
            this.ccToolStripMenuItem.Size = new System.Drawing.Size(434, 26);
            this.ccToolStripMenuItem.Text = "Conversão de Velocidade m/s - km/s";
            this.ccToolStripMenuItem.Click += new System.EventHandler(this.ccToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(431, 6);
            // 
            // quantidadeDeÁguaEValorASerPagoToolStripMenuItem
            // 
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem.Name = "quantidadeDeÁguaEValorASerPagoToolStripMenuItem";
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem.Size = new System.Drawing.Size(434, 26);
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem.Text = "Quantidade de água  e valor a ser pago";
            this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem.Click += new System.EventHandler(this.quantidadeDeÁguaEValorASerPagoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(431, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(434, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio_1.Properties.Resources.calculo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 593);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator bbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ccToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quantidadeDeÁguaEValorASerPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

