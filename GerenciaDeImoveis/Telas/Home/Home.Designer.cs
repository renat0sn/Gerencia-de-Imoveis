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
            this.groupBox_AreaConstruida = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Terreno = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Preco = new System.Windows.Forms.GroupBox();
            this.label_ValorMaximoPreco = new System.Windows.Forms.Label();
            this.label_ValorMinimoPreco = new System.Windows.Forms.Label();
            this.trackBar_ValorMaximoPreco = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_ValorMinimoPreco = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1_Busca = new System.Windows.Forms.Panel();
            this.button_Add = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Busca = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_Busca = new System.Windows.Forms.TextBox();
            this.button_Busca = new System.Windows.Forms.Button();
            this.flowLayoutPanel_ListaCasas = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel1.SuspendLayout();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            this.groupBox_AreaConstruida.SuspendLayout();
            this.groupBox_Terreno.SuspendLayout();
            this.groupBox_Preco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ValorMaximoPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ValorMinimoPreco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1_Busca.SuspendLayout();
            this.flowLayoutPanel_Busca.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainerPrincipal.Panel1.Controls.Add(this.button1);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.groupBox2);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.groupBox_AreaConstruida);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.groupBox_Terreno);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.groupBox_Preco);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.label1);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.AutoScroll = true;
            this.splitContainerPrincipal.Panel2.AutoScrollMinSize = new System.Drawing.Size(352, 400);
            this.splitContainerPrincipal.Panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainerPrincipal.Panel2.Controls.Add(this.panel1_Busca);
            this.splitContainerPrincipal.Panel2.Controls.Add(this.flowLayoutPanel_ListaCasas);
            this.splitContainerPrincipal.Size = new System.Drawing.Size(1203, 769);
            this.splitContainerPrincipal.SplitterDistance = 456;
            this.splitContainerPrincipal.SplitterWidth = 3;
            this.splitContainerPrincipal.TabIndex = 0;
            // 
            // groupBox_AreaConstruida
            // 
            this.groupBox_AreaConstruida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_AreaConstruida.Controls.Add(this.label11);
            this.groupBox_AreaConstruida.Controls.Add(this.label10);
            this.groupBox_AreaConstruida.Controls.Add(this.comboBox4);
            this.groupBox_AreaConstruida.Controls.Add(this.comboBox3);
            this.groupBox_AreaConstruida.Controls.Add(this.label4);
            this.groupBox_AreaConstruida.Controls.Add(this.label5);
            this.groupBox_AreaConstruida.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.groupBox_AreaConstruida.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox_AreaConstruida.Location = new System.Drawing.Point(267, 462);
            this.groupBox_AreaConstruida.Name = "groupBox_AreaConstruida";
            this.groupBox_AreaConstruida.Size = new System.Drawing.Size(177, 142);
            this.groupBox_AreaConstruida.TabIndex = 12;
            this.groupBox_AreaConstruida.TabStop = false;
            this.groupBox_AreaConstruida.Text = "Área construída";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(133, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 27);
            this.label11.TabIndex = 8;
            this.label11.Text = "m²";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(133, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "m²";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000",
            "10000"});
            this.comboBox4.Location = new System.Drawing.Point(56, 95);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox4.Size = new System.Drawing.Size(71, 31);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000",
            "10000"});
            this.comboBox3.Location = new System.Drawing.Point(56, 41);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox3.Size = new System.Drawing.Size(71, 31);
            this.comboBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Até: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "De: ";
            // 
            // groupBox_Terreno
            // 
            this.groupBox_Terreno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Terreno.Controls.Add(this.label9);
            this.groupBox_Terreno.Controls.Add(this.label8);
            this.groupBox_Terreno.Controls.Add(this.comboBox2);
            this.groupBox_Terreno.Controls.Add(this.comboBox1);
            this.groupBox_Terreno.Controls.Add(this.label6);
            this.groupBox_Terreno.Controls.Add(this.label7);
            this.groupBox_Terreno.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.groupBox_Terreno.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox_Terreno.Location = new System.Drawing.Point(12, 462);
            this.groupBox_Terreno.Name = "groupBox_Terreno";
            this.groupBox_Terreno.Size = new System.Drawing.Size(177, 142);
            this.groupBox_Terreno.TabIndex = 11;
            this.groupBox_Terreno.TabStop = false;
            this.groupBox_Terreno.Text = "Terreno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(132, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "m²";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(132, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "m²";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000",
            "3000",
            "5000",
            "10000",
            "20000"});
            this.comboBox2.Location = new System.Drawing.Point(56, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(71, 31);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000",
            "3000",
            "5000",
            "10000",
            "20000"});
            this.comboBox1.Location = new System.Drawing.Point(56, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(71, 31);
            this.comboBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Até: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "De: ";
            // 
            // groupBox_Preco
            // 
            this.groupBox_Preco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Preco.Controls.Add(this.label_ValorMaximoPreco);
            this.groupBox_Preco.Controls.Add(this.label_ValorMinimoPreco);
            this.groupBox_Preco.Controls.Add(this.trackBar_ValorMaximoPreco);
            this.groupBox_Preco.Controls.Add(this.label3);
            this.groupBox_Preco.Controls.Add(this.label2);
            this.groupBox_Preco.Controls.Add(this.trackBar_ValorMinimoPreco);
            this.groupBox_Preco.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.groupBox_Preco.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox_Preco.Location = new System.Drawing.Point(12, 348);
            this.groupBox_Preco.Name = "groupBox_Preco";
            this.groupBox_Preco.Size = new System.Drawing.Size(432, 108);
            this.groupBox_Preco.TabIndex = 10;
            this.groupBox_Preco.TabStop = false;
            this.groupBox_Preco.Text = "Preço";
            // 
            // label_ValorMaximoPreco
            // 
            this.label_ValorMaximoPreco.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Italic);
            this.label_ValorMaximoPreco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ValorMaximoPreco.Location = new System.Drawing.Point(51, 68);
            this.label_ValorMaximoPreco.Name = "label_ValorMaximoPreco";
            this.label_ValorMaximoPreco.Size = new System.Drawing.Size(154, 31);
            this.label_ValorMaximoPreco.TabIndex = 5;
            this.label_ValorMaximoPreco.Text = "Máximo";
            this.label_ValorMaximoPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ValorMinimoPreco
            // 
            this.label_ValorMinimoPreco.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Italic);
            this.label_ValorMinimoPreco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ValorMinimoPreco.Location = new System.Drawing.Point(53, 27);
            this.label_ValorMinimoPreco.Name = "label_ValorMinimoPreco";
            this.label_ValorMinimoPreco.Size = new System.Drawing.Size(152, 31);
            this.label_ValorMinimoPreco.TabIndex = 4;
            this.label_ValorMinimoPreco.Tag = "";
            this.label_ValorMinimoPreco.Text = "Mínimo";
            this.label_ValorMinimoPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_ValorMaximoPreco
            // 
            this.trackBar_ValorMaximoPreco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar_ValorMaximoPreco.AutoSize = false;
            this.trackBar_ValorMaximoPreco.Location = new System.Drawing.Point(211, 71);
            this.trackBar_ValorMaximoPreco.Maximum = 70;
            this.trackBar_ValorMaximoPreco.Name = "trackBar_ValorMaximoPreco";
            this.trackBar_ValorMaximoPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_ValorMaximoPreco.Size = new System.Drawing.Size(210, 26);
            this.trackBar_ValorMaximoPreco.TabIndex = 3;
            this.trackBar_ValorMaximoPreco.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_ValorMaximoPreco.Value = 70;
            this.trackBar_ValorMaximoPreco.ValueChanged += new System.EventHandler(this.trackBarMaximo_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Até: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "De: ";
            // 
            // trackBar_ValorMinimoPreco
            // 
            this.trackBar_ValorMinimoPreco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar_ValorMinimoPreco.AutoSize = false;
            this.trackBar_ValorMinimoPreco.Location = new System.Drawing.Point(211, 33);
            this.trackBar_ValorMinimoPreco.Maximum = 70;
            this.trackBar_ValorMinimoPreco.Name = "trackBar_ValorMinimoPreco";
            this.trackBar_ValorMinimoPreco.Size = new System.Drawing.Size(210, 23);
            this.trackBar_ValorMinimoPreco.TabIndex = 0;
            this.trackBar_ValorMinimoPreco.Tag = "label_ValorMinimo";
            this.trackBar_ValorMinimoPreco.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_ValorMinimoPreco.ValueChanged += new System.EventHandler(this.trackBarMinimo_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(432, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bairro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(2, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(428, 190);
            this.panel1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox1.Location = new System.Drawing.Point(4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 31);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Alto da Boa Vista";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox10.Location = new System.Drawing.Point(249, 153);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(180, 31);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Jardim Santo Amaro";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox9.Location = new System.Drawing.Point(249, 116);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(155, 31);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Jardim Prudência";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox2.Location = new System.Drawing.Point(4, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(142, 31);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Brooklin Velho";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox8.Location = new System.Drawing.Point(249, 79);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(158, 31);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Jardim Petrópolis";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox3.Location = new System.Drawing.Point(4, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(199, 31);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Chácara Monte Alegre";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox7.Location = new System.Drawing.Point(249, 42);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(157, 31);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Jardim Marajoara";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox4.Location = new System.Drawing.Point(4, 116);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(130, 31);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Granja Julieta";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox6.Location = new System.Drawing.Point(249, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(170, 31);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Jardim dos Estados";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Gill Sans MT", 13F);
            this.checkBox5.Location = new System.Drawing.Point(3, 153);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(152, 31);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Jardim Cordeiro";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::GerenciaDeImoveis.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1_Busca
            // 
            this.panel1_Busca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1_Busca.Controls.Add(this.button_Add);
            this.panel1_Busca.Controls.Add(this.flowLayoutPanel_Busca);
            this.panel1_Busca.Location = new System.Drawing.Point(-5, 3);
            this.panel1_Busca.Name = "panel1_Busca";
            this.panel1_Busca.Size = new System.Drawing.Size(696, 81);
            this.panel1_Busca.TabIndex = 0;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Add.BackColor = System.Drawing.Color.Transparent;
            this.button_Add.BackgroundImage = global::GerenciaDeImoveis.Properties.Resources.mais;
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(25, 6);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(91, 68);
            this.button_Add.TabIndex = 0;
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // flowLayoutPanel_Busca
            // 
            this.flowLayoutPanel_Busca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Busca.Controls.Add(this.textBox_Busca);
            this.flowLayoutPanel_Busca.Controls.Add(this.button_Busca);
            this.flowLayoutPanel_Busca.Location = new System.Drawing.Point(195, 23);
            this.flowLayoutPanel_Busca.Name = "flowLayoutPanel_Busca";
            this.flowLayoutPanel_Busca.Size = new System.Drawing.Size(387, 34);
            this.flowLayoutPanel_Busca.TabIndex = 3;
            // 
            // textBox_Busca
            // 
            this.textBox_Busca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_Busca.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.textBox_Busca.Location = new System.Drawing.Point(3, 3);
            this.textBox_Busca.Name = "textBox_Busca";
            this.textBox_Busca.Size = new System.Drawing.Size(333, 29);
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
            this.button_Busca.Location = new System.Drawing.Point(342, 3);
            this.button_Busca.Name = "button_Busca";
            this.button_Busca.Size = new System.Drawing.Size(41, 29);
            this.button_Busca.TabIndex = 2;
            this.button_Busca.UseVisualStyleBackColor = true;
            this.button_Busca.Click += new System.EventHandler(this.button_Busca_Click);
            // 
            // flowLayoutPanel_ListaCasas
            // 
            this.flowLayoutPanel_ListaCasas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel_ListaCasas.AutoScroll = true;
            this.flowLayoutPanel_ListaCasas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel_ListaCasas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_ListaCasas.Location = new System.Drawing.Point(0, 123);
            this.flowLayoutPanel_ListaCasas.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_ListaCasas.Name = "flowLayoutPanel_ListaCasas";
            this.flowLayoutPanel_ListaCasas.Size = new System.Drawing.Size(708, 637);
            this.flowLayoutPanel_ListaCasas.TabIndex = 1;
            this.flowLayoutPanel_ListaCasas.WrapContents = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox2.Location = new System.Drawing.Point(88, 610);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 76);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estilo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(37, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 31);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Térreo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(150, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 31);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sobrado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 16F);
            this.button1.Location = new System.Drawing.Point(12, 714);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(432, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aplicar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 769);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Name = "Home";
            this.Text = "Nakano Imóveis";
            this.splitContainerPrincipal.Panel1.ResumeLayout(false);
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            this.groupBox_AreaConstruida.ResumeLayout(false);
            this.groupBox_AreaConstruida.PerformLayout();
            this.groupBox_Terreno.ResumeLayout(false);
            this.groupBox_Terreno.PerformLayout();
            this.groupBox_Preco.ResumeLayout(false);
            this.groupBox_Preco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ValorMaximoPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ValorMinimoPreco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1_Busca.ResumeLayout(false);
            this.flowLayoutPanel_Busca.ResumeLayout(false);
            this.flowLayoutPanel_Busca.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.GroupBox groupBox_Preco;
        private System.Windows.Forms.TrackBar trackBar_ValorMaximoPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ValorMinimoPreco;
        private System.Windows.Forms.GroupBox groupBox_Terreno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_AreaConstruida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar_ValorMinimoPreco;
        private System.Windows.Forms.Label label_ValorMaximoPreco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}

