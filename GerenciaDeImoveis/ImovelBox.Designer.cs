namespace GerenciaDeImoveis
{
    partial class ImovelBox
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pInferior = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.areaconstruida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.terreno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.indicacao = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.estilo = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pInferior.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.f1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pInferior);
            this.panel1.Controls.Add(this.preco);
            this.panel1.Controls.Add(this.bairro);
            this.panel1.Controls.Add(this.endereco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 138);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // pInferior
            // 
            this.pInferior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInferior.Controls.Add(this.button2);
            this.pInferior.Controls.Add(this.button1);
            this.pInferior.Controls.Add(this.areaconstruida);
            this.pInferior.Controls.Add(this.label3);
            this.pInferior.Controls.Add(this.terreno);
            this.pInferior.Controls.Add(this.label1);
            this.pInferior.Controls.Add(this.flowLayoutPanel2);
            this.pInferior.Controls.Add(this.flowLayoutPanel1);
            this.pInferior.Controls.Add(this.f1);
            this.pInferior.Location = new System.Drawing.Point(-2, 70);
            this.pInferior.Margin = new System.Windows.Forms.Padding(0);
            this.pInferior.Name = "pInferior";
            this.pInferior.Size = new System.Drawing.Size(665, 67);
            this.pInferior.TabIndex = 3;
            this.pInferior.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GerenciaDeImoveis.Properties.Resources.x;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(615, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GerenciaDeImoveis.Properties.Resources.escrita;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(580, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // areaconstruida
            // 
            this.areaconstruida.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.areaconstruida.Location = new System.Drawing.Point(156, 32);
            this.areaconstruida.Margin = new System.Windows.Forms.Padding(0);
            this.areaconstruida.Name = "areaconstruida";
            this.areaconstruida.Size = new System.Drawing.Size(67, 35);
            this.areaconstruida.TabIndex = 7;
            this.areaconstruida.Text = "label1";
            this.areaconstruida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.areaconstruida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área construída: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // terreno
            // 
            this.terreno.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.terreno.Location = new System.Drawing.Point(98, 0);
            this.terreno.Margin = new System.Windows.Forms.Padding(0);
            this.terreno.Name = "terreno";
            this.terreno.Size = new System.Drawing.Size(81, 35);
            this.terreno.TabIndex = 5;
            this.terreno.Text = "label1";
            this.terreno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.terreno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Terreno: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel2.Controls.Add(this.indicacao);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(491, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(175, 35);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GerenciaDeImoveis.Properties.Resources.check;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // indicacao
            // 
            this.indicacao.AutoSize = true;
            this.indicacao.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.indicacao.Location = new System.Drawing.Point(27, 0);
            this.indicacao.Margin = new System.Windows.Forms.Padding(0);
            this.indicacao.Name = "indicacao";
            this.indicacao.Size = new System.Drawing.Size(49, 23);
            this.indicacao.TabIndex = 11;
            this.indicacao.Text = "label1";
            this.indicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.indicacao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.status);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(282, 32);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GerenciaDeImoveis.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.status.Location = new System.Drawing.Point(27, 0);
            this.status.Margin = new System.Windows.Forms.Padding(0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(49, 23);
            this.status.TabIndex = 10;
            this.status.Text = "label1";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // f1
            // 
            this.f1.Controls.Add(this.pictureBox1);
            this.f1.Controls.Add(this.estilo);
            this.f1.Location = new System.Drawing.Point(282, 0);
            this.f1.Margin = new System.Windows.Forms.Padding(0);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(100, 35);
            this.f1.TabIndex = 0;
            this.f1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciaDeImoveis.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // estilo
            // 
            this.estilo.AutoSize = true;
            this.estilo.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.estilo.Location = new System.Drawing.Point(27, 0);
            this.estilo.Margin = new System.Windows.Forms.Padding(0);
            this.estilo.Name = "estilo";
            this.estilo.Size = new System.Drawing.Size(49, 23);
            this.estilo.TabIndex = 8;
            this.estilo.Text = "label1";
            this.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estilo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // preco
            // 
            this.preco.Font = new System.Drawing.Font("Gill Sans MT", 19F, System.Drawing.FontStyle.Bold);
            this.preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.preco.Location = new System.Drawing.Point(439, 0);
            this.preco.Margin = new System.Windows.Forms.Padding(0);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(223, 70);
            this.preco.TabIndex = 2;
            this.preco.Text = "label1";
            this.preco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.Font = new System.Drawing.Font("Gill Sans MT", 11F);
            this.bairro.Location = new System.Drawing.Point(22, 38);
            this.bairro.Margin = new System.Windows.Forms.Padding(0);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(45, 21);
            this.bairro.TabIndex = 1;
            this.bairro.Text = "label1";
            this.bairro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Font = new System.Drawing.Font("Gill Sans MT", 17F);
            this.endereco.Location = new System.Drawing.Point(20, 5);
            this.endereco.Margin = new System.Windows.Forms.Padding(0);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(70, 33);
            this.endereco.TabIndex = 0;
            this.endereco.Text = "label1";
            this.endereco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImovelBox_MouseClick);
            // 
            // ImovelBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ImovelBox";
            this.Size = new System.Drawing.Size(665, 138);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pInferior.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.f1.ResumeLayout(false);
            this.f1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pInferior;
        public System.Windows.Forms.Label areaconstruida;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label terreno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label indicacao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label status;
        private System.Windows.Forms.FlowLayoutPanel f1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label estilo;
        public System.Windows.Forms.Label preco;
        public System.Windows.Forms.Label bairro;
        public System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
