namespace GerenciaDeImoveis
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
            this.splitContainerPrincipal = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel_ListaCasas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1_Busca = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_Busca = new System.Windows.Forms.TextBox();
            this.button_Busca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            this.panel1_Busca.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerPrincipal
            // 
            this.splitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPrincipal.IsSplitterFixed = true;
            this.splitContainerPrincipal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPrincipal.Name = "splitContainerPrincipal";
            // 
            // splitContainerPrincipal.Panel1
            // 
            this.splitContainerPrincipal.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.AutoScroll = true;
            this.splitContainerPrincipal.Panel2.AutoScrollMinSize = new System.Drawing.Size(352, 400);
            this.splitContainerPrincipal.Panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainerPrincipal.Panel2.Controls.Add(this.button1);
            this.splitContainerPrincipal.Panel2.Controls.Add(this.flowLayoutPanel_ListaCasas);
            this.splitContainerPrincipal.Panel2.Controls.Add(this.panel1_Busca);
            this.splitContainerPrincipal.Size = new System.Drawing.Size(979, 711);
            this.splitContainerPrincipal.SplitterDistance = 299;
            this.splitContainerPrincipal.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::GerenciaDeImoveis.Properties.Resources.mais;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(558, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 72);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_ListaCasas
            // 
            this.flowLayoutPanel_ListaCasas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_ListaCasas.AutoSize = true;
            this.flowLayoutPanel_ListaCasas.Location = new System.Drawing.Point(3, 90);
            this.flowLayoutPanel_ListaCasas.Name = "flowLayoutPanel_ListaCasas";
            this.flowLayoutPanel_ListaCasas.Size = new System.Drawing.Size(670, 618);
            this.flowLayoutPanel_ListaCasas.TabIndex = 1;
            // 
            // panel1_Busca
            // 
            this.panel1_Busca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1_Busca.Controls.Add(this.flowLayoutPanel2);
            this.panel1_Busca.Location = new System.Drawing.Point(3, 3);
            this.panel1_Busca.Name = "panel1_Busca";
            this.panel1_Busca.Size = new System.Drawing.Size(670, 81);
            this.panel1_Busca.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.Controls.Add(this.textBox_Busca);
            this.flowLayoutPanel2.Controls.Add(this.button_Busca);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(176, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(353, 34);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // textBox_Busca
            // 
            this.textBox_Busca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_Busca.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.textBox_Busca.Location = new System.Drawing.Point(3, 3);
            this.textBox_Busca.Name = "textBox_Busca";
            this.textBox_Busca.Size = new System.Drawing.Size(299, 29);
            this.textBox_Busca.TabIndex = 0;
            // 
            // button_Busca
            // 
            this.button_Busca.BackgroundImage = global::GerenciaDeImoveis.Properties.Resources.lupa;
            this.button_Busca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Busca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Busca.FlatAppearance.BorderSize = 0;
            this.button_Busca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Busca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Busca.Location = new System.Drawing.Point(308, 3);
            this.button_Busca.Name = "button_Busca";
            this.button_Busca.Size = new System.Drawing.Size(41, 29);
            this.button_Busca.TabIndex = 2;
            this.button_Busca.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 711);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Name = "Form1";
            this.Text = "Nakano Imóveis";
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            this.splitContainerPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            this.panel1_Busca.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerPrincipal;
        private System.Windows.Forms.Panel panel1_Busca;
        private System.Windows.Forms.TextBox textBox_Busca;
        private System.Windows.Forms.Button button_Busca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ListaCasas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
    }
}

