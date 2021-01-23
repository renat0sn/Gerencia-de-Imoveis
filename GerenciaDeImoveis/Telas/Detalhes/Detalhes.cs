using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciaDeImoveis.Model;

namespace GerenciaDeImoveis
{
    public partial class Detalhes : Form
    {
        private Imovel Imovel { get; set; }

        public Detalhes(Imovel i)
        {
            Imovel = i;
            InitializeComponent();
            InitScreen();
        }

        public void InitScreen()
        {
            Label enderecoBairro = new Label();
            Label preco = new Label();
            Label terreno = new Label();
            Label areaConstruida = new Label();
            Label nGaragens = new Label();
            Label nDorm = new Label();
            Label estilo = new Label();
            Label status = new Label();
            Label indicacao = new Label();
            Label ic1 = new Label();
            Label ic2 = new Label();
            Label ic3 = new Label();

            FlowLayoutPanel f1 = new FlowLayoutPanel();
            FlowLayoutPanel f2 = new FlowLayoutPanel();
            FlowLayoutPanel f3 = new FlowLayoutPanel();

            enderecoBairro.Location = new Point(0, 7);
            enderecoBairro.Name = "enderecoBairro";
            enderecoBairro.Size = new Size(518, 59);
            enderecoBairro.ForeColor = Color.White;
            enderecoBairro.TextAlign = ContentAlignment.MiddleCenter;
            enderecoBairro.Text = Imovel.Endereco + " (" + Imovel.Bairro.ToString().Replace("_", " ") + ")";
            enderecoBairro.Font = PreencherStringNoLabel(enderecoBairro);
            
            preco.Font = new Font("Gill Sans MT", 17F);
            preco.Location = new Point(0, 44);
            preco.Name = "preco";
            preco.Size = new Size(502, 62);
            preco.ForeColor = Color.White;
            preco.TextAlign = ContentAlignment.MiddleCenter;
            preco.Text = "R$ " + Imovel.Preco.ToString("N2");

            panel2.Controls.Add(enderecoBairro);
            panel2.Controls.Add(preco);

            terreno.Font = new Font("Gill Sans MT", 14F);
            terreno.Location = new Point(30, 120);
            terreno.Name = "terreno";
            terreno.AutoSize = true;
            terreno.ForeColor = Color.White;
            terreno.Text = "Terreno: " + Imovel.Terreno.ToString().PadLeft(18) + " m²";

            areaConstruida.Font = new Font("Gill Sans MT", 14F);
            areaConstruida.Location = new Point(30, 165);
            areaConstruida.Name = "areaConstruida";
            areaConstruida.AutoSize = true;
            areaConstruida.ForeColor = Color.White;
            areaConstruida.Text = "Área construída: " + Imovel.AreaConstruida.ToString().PadLeft(6) + " m²";

            nDorm.Font = new Font("Gill Sans MT", 14F);
            nDorm.Location = new Point(30, 210);
            nDorm.Name = "nDorm";
            nDorm.AutoSize = true;
            nDorm.ForeColor = Color.White;
            nDorm.Text = "Dormitórios: " + Imovel.nDormitorios.ToString().PadLeft(10);

            nGaragens.Font = new Font("Gill Sans MT", 14F);
            nGaragens.Location = new Point(30, 255);
            nGaragens.Name = "nGaragens";
            nGaragens.AutoSize = true;
            nGaragens.ForeColor = Color.White;
            nGaragens.Text = "Garagens: " + Imovel.nGaragens.ToString().PadLeft(15);

            ic1.Image = Properties.Resources.check;
            ic1.Size = new Size(16, 16);
            ic1.Anchor = AnchorStyles.Left;
            ic1.Name = "ic";

            ic2.Image = Properties.Resources.check;
            ic2.Size = new Size(16, 16);
            ic2.Anchor = AnchorStyles.Left;
            ic2.Name = "ic";

            ic3.Image = Properties.Resources.check;
            ic3.Size = new Size(16, 16);
            ic3.Anchor = AnchorStyles.Left;
            ic3.Name = "ic";

            f1.Location = new Point(300, 120);
            f1.Name = "f1";
            f1.Size = new Size(250, 30);
            f1.FlowDirection = FlowDirection.LeftToRight;
            f1.Controls.Add(ic1);

            f2.Location = new Point(300, 187);
            f2.Name = "f2";
            f2.Size = new Size(250, 30);
            f2.FlowDirection = FlowDirection.LeftToRight;
            f2.Controls.Add(ic2);

            f3.Location = new Point(300, 255);
            f3.Name = "f3";
            f3.Size = new Size(250, 30);
            f3.FlowDirection = FlowDirection.LeftToRight;
            f3.Controls.Add(ic3);

            estilo.Font = new Font("Gill Sans MT", 14F);
            estilo.Location = new Point(300, 120);
            estilo.Name = "estilo";
            estilo.AutoSize = true;
            estilo.ForeColor = Color.White;
            estilo.Text = Imovel.Estilo.ToString();
            f1.Controls.Add(estilo);

            status.Font = new Font("Gill Sans MT", 14F);
            status.Location = new Point(300, 187);
            status.Name = "status";
            status.AutoSize = true;
            status.ForeColor = Color.White;
            status.Text = Imovel.Status.ToString().Replace("_", " ");
            f2.Controls.Add(status);

            indicacao.Font = new Font("Gill Sans MT", 14F);
            indicacao.Location = new Point(300, 255);
            indicacao.Name = "indicacao";
            indicacao.AutoSize = true;
            indicacao.ForeColor = Color.White;
            indicacao.Text = "Indicação: " + Imovel.Indicacao.ToString();
            f3.Controls.Add(indicacao);

            richTextBox_Observacoes.Text = Imovel.Observacoes;
            

            panel1.Controls.Add(terreno);
            panel1.Controls.Add(areaConstruida);
            panel1.Controls.Add(nDorm);
            panel1.Controls.Add(nGaragens);
            panel1.Controls.Add(f1);
            panel1.Controls.Add(f2);
            panel1.Controls.Add(f3);
        }

        public Font PreencherStringNoLabel(Label label)
        {
            float f = 17;
            Font font = new Font("Gill Sans MT", 17);
            Size s = TextRenderer.MeasureText(label.Text, font);

            while (s.Width > 510)
            {
                f -= 0.5F;
                font = new Font(label.Font.Name, f);
                s = TextRenderer.MeasureText(label.Text, font);
            }

            return font;
        }
    }
}
