namespace GerenciaDeImoveis
{
    partial class Home
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
            this.panel1_Busca = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Busca = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_Busca = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_ListaCasas = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Busca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel1.SuspendLayout();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            this.panel1_Busca.SuspendLayout();
            this.flowLayoutPanel_Busca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainerPrincipal.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.AutoScroll = true;
            this.splitContainerPrincipal.Panel2.AutoScrollMinSize = new System.Drawing.Size(352, 400);
            this.splitContainerPrincipal.Panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainerPrincipal.Panel2.Controls.Add(this.button_Add);
            this.splitContainerPrincipal.Panel2.Controls.Add(this.panel1_Busca);
            this.splitContainerPrincipal.Panel2.Controls.Add(this.flowLayoutPanel_ListaCasas);
            this.splitContainerPrincipal.Size = new System.Drawing.Size(999, 711);
            this.splitContainerPrincipal.SplitterDistance = 299;
            this.splitContainerPrincipal.SplitterWidth = 3;
            this.splitContainerPrincipal.TabIndex = 0;
            // 
            // panel1_Busca
            // 
            this.panel1_Busca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1_Busca.Controls.Add(this.flowLayoutPanel_Busca);
            this.panel1_Busca.Location = new System.Drawing.Point(3, 3);
            this.panel1_Busca.Name = "panel1_Busca";
            this.panel1_Busca.Size = new System.Drawing.Size(673, 81);
            this.panel1_Busca.TabIndex = 0;
            // 
            // flowLayoutPanel_Busca
            // 
            this.flowLayoutPanel_Busca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Busca.Controls.Add(this.textBox_Busca);
            this.flowLayoutPanel_Busca.Controls.Add(this.button_Busca);
            this.flowLayoutPanel_Busca.Location = new System.Drawing.Point(191, 24);
            this.flowLayoutPanel_Busca.Name = "flowLayoutPanel_Busca";
            this.flowLayoutPanel_Busca.Size = new System.Drawing.Size(353, 34);
            this.flowLayoutPanel_Busca.TabIndex = 3;
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
            // flowLayoutPanel_ListaCasas
            // 
            this.flowLayoutPanel_ListaCasas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_ListaCasas.AutoScroll = true;
            this.flowLayoutPanel_ListaCasas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel_ListaCasas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_ListaCasas.Location = new System.Drawing.Point(3, 133);
            this.flowLayoutPanel_ListaCasas.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_ListaCasas.Name = "flowLayoutPanel_ListaCasas";
            this.flowLayoutPanel_ListaCasas.Size = new System.Drawing.Size(694, 569);
            this.flowLayoutPanel_ListaCasas.TabIndex = 1;
            this.flowLayoutPanel_ListaCasas.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciaDeImoveis.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.BackColor = System.Drawing.Color.Transparent;
            this.button_Add.BackgroundImage = global::GerenciaDeImoveis.Properties.Resources.mais;
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(549, 602);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(91, 68);
            this.button_Add.TabIndex = 0;
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 711);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Name = "Home";
            this.Text = "Nakano Imóveis";
            this.splitContainerPrincipal.Panel1.ResumeLayout(false);
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            this.panel1_Busca.ResumeLayout(false);
            this.flowLayoutPanel_Busca.ResumeLayout(false);
            this.flowLayoutPanel_Busca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerPrincipal;
        private System.Windows.Forms.Panel panel1_Busca;
        private System.Windows.Forms.TextBox textBox_Busca;
        private System.Windows.Forms.Button button_Busca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ListaCasas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Busca;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

