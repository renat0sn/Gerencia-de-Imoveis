using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using GerenciaDeImoveis.Model;

namespace GerenciaDeImoveis
{
    public partial class Home : Form
    {
        public List<Imovel> Imoveis { get; set; }

        public Home()
        {
            InitializeComponent();
            Imoveis = new List<Imovel>();
        }

        public void NovoBloco(Imovel imovel)
        {
            int indexImovel = Imoveis.IndexOf(imovel);

            Panel bloco = new Panel();
            Panel pImagem = new Panel();
            Panel pInferior = new Panel();

            FlowLayoutPanel f1 = new FlowLayoutPanel();
            FlowLayoutPanel f2 = new FlowLayoutPanel();
            FlowLayoutPanel f3 = new FlowLayoutPanel();

            Label endereco = new Label();
            Label bairro = new Label();
            Label preco = new Label();
            Label terrenoLabel = new Label();
            Label terrenoValue = new Label();
            Label areaLabel = new Label();
            Label areaValue = new Label();
            Label estilo = new Label();
            Label status = new Label();
            Label indicacao = new Label();

            PictureBox casa = new PictureBox();
            PictureBox ic1 = new PictureBox();
            PictureBox ic2 = new PictureBox();
            PictureBox ic3 = new PictureBox();

            Button editar = new Button();
            Button excluir = new Button();

            bloco.BorderStyle = BorderStyle.FixedSingle;
            bloco.Cursor = Cursors.Hand;
            bloco.Margin = new Padding(0,0,0,10);
            bloco.Name = "bloco" + indexImovel.ToString();
            bloco.Padding = new Padding(0);
            bloco.Size = new Size(667, 140);
            bloco.Controls.Add(endereco);
            bloco.Controls.Add(bairro);
            bloco.Controls.Add(preco);
            bloco.Controls.Add(pImagem);
            bloco.Controls.Add(pInferior);

            pImagem.Controls.Add(casa);
            pImagem.Dock = DockStyle.Left;
            pImagem.Location = new Point(0, 0);
            pImagem.Margin = new Padding(0);
            pImagem.Name = "pImagem" + indexImovel.ToString();
            pImagem.Padding = new Padding(5);
            pImagem.Size = new Size(126, 138);

            pInferior.BorderStyle = BorderStyle.Fixed3D;
            pInferior.Location = new Point(119, 70);
            pInferior.Name = "pInferior" + indexImovel.ToString();
            pInferior.Size = new Size(547, 69);
            pInferior.Controls.Add(f1);
            pInferior.Controls.Add(f2);
            pInferior.Controls.Add(f3);
            pInferior.Controls.Add(terrenoLabel);
            pInferior.Controls.Add(terrenoValue);
            pInferior.Controls.Add(areaLabel);
            pInferior.Controls.Add(areaValue);
            pInferior.Controls.Add(editar);
            pInferior.Controls.Add(excluir);

            f1.Controls.Add(ic1);
            f1.Controls.Add(estilo);
            f1.Location = new Point(229, 0);
            f1.Margin = new Padding(0);
            f1.Name = "f1" + indexImovel.ToString();
            f1.Size = new Size(100, 35);

            f2.Controls.Add(ic2);
            f2.Controls.Add(status);
            f2.Location = new Point(229, 32);
            f2.Margin = new Padding(0);
            f2.Name = "f2" + indexImovel.ToString();
            f2.Size = new Size(200, 35);

            f3.Controls.Add(ic3);
            f3.Controls.Add(indicacao);
            f3.Location = new Point(361, 0);
            f3.Margin = new Padding(0);
            f3.Name = "f3" + indexImovel.ToString();
            f3.Size = new Size(180, 35);

            float font = formatarLabel(endereco);
            endereco.AutoSize = true;
            endereco.Font = new Font("Gill Sans MT", font);
            endereco.Location = new Point(142, 5);
            endereco.Margin = new Padding(0);
            endereco.Name = "endereco" + indexImovel.ToString();
            endereco.Size = new Size(299, 33);
            endereco.Text = imovel.Endereco;
            endereco.TextAlign = ContentAlignment.MiddleLeft;

            bairro.AutoSize = true;
            bairro.Font = new Font("Gill Sans MT", 11F);
            bairro.Location = new Point(144, 38);
            bairro.Name = "bairro" + indexImovel.ToString();
            bairro.Size = new Size(123, 21);
            bairro.Text = "(" + imovel.Bairro.ToString().Replace("_", " ") + ")";

            preco.Font = new Font("Gill Sans MT", 19F, FontStyle.Bold);
            preco.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            preco.Location = new Point(439, 0);
            preco.Margin = new Padding(0);
            preco.Name = "preco" + indexImovel.ToString();
            preco.Size = new Size(223, 70);
            preco.Text = "R$" + imovel.Preco.ToString("N2");
            preco.TextAlign = ContentAlignment.MiddleRight;

            terrenoLabel.Font = new Font("Gill Sans MT", 13F);
            terrenoLabel.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            terrenoLabel.Location = new Point(21, 0);
            terrenoLabel.Margin = new Padding(0);
            terrenoLabel.Name = "terrenoLabel" + indexImovel.ToString();
            terrenoLabel.Size = new Size(78, 35);
            terrenoLabel.Text = "Terreno:";
            terrenoLabel.TextAlign = ContentAlignment.MiddleLeft;

            terrenoValue.Font = new Font("Gill Sans MT", 12F);
            terrenoValue.Location = new Point(93, 0);
            terrenoValue.Name = "terrenoValue" + indexImovel.ToString();
            terrenoValue.Size = new Size(81, 35);
            terrenoValue.Text = imovel.Terreno.ToString() + " m²";
            terrenoValue.TextAlign = ContentAlignment.MiddleLeft;

            areaLabel.Font = new Font("Gill Sans MT", 13F);
            areaLabel.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            areaLabel.Location = new Point(21, 32);
            areaLabel.Margin = new Padding(0);
            areaLabel.Name = "areaLabel" + indexImovel.ToString();
            areaLabel.Size = new Size(135, 35);
            areaLabel.Text = "Área construída:";
            areaLabel.TextAlign = ContentAlignment.MiddleLeft;

            areaValue.Font = new Font("Gill Sans MT", 12F);
            areaValue.Location = new Point(149, 32);
            areaValue.Name = "areaValue" + indexImovel.ToString();
            areaValue.Size = new Size(67, 35);
            areaValue.Text = imovel.AreaConstruida.ToString() + " m²";
            areaValue.TextAlign = ContentAlignment.MiddleLeft;

            estilo.AutoSize = true;
            estilo.Font = new Font("Gill Sans MT", 12F);
            estilo.Location = new Point(27, 6);
            estilo.Margin = new Padding(0, 0, 3, 0);
            estilo.Name = "estilo" + indexImovel.ToString();
            estilo.Size = new Size(64, 23);
            estilo.Text = imovel.Estilo.ToString();
            estilo.TextAlign = ContentAlignment.MiddleLeft;

            status.AutoSize = true;
            status.Font = new Font("Gill Sans MT", 12F);
            status.Location = new Point(27, 6);
            status.Margin = new Padding(0, 0, 3, 0);
            status.Name = "status" + indexImovel.ToString();
            status.Size = new Size(132, 23);
            status.Text = imovel.Status.ToString().Replace("_", " ");
            status.TextAlign = ContentAlignment.MiddleLeft;

            indicacao.AutoSize = true;
            indicacao.Font = new Font("Gill Sans MT", 12F);
            indicacao.Location = new Point(27, 6);
            indicacao.Margin = new Padding(0, 0, 3, 0);
            indicacao.Name = "indicacao" + indexImovel.ToString();
            indicacao.Size = new Size(147, 23);
            indicacao.Text = "Indicação: " + imovel.Indicacao.ToString().Replace("_", " ");
            indicacao.TextAlign = ContentAlignment.MiddleLeft;

            casa.Dock = DockStyle.Fill;
            casa.Image = imovel.Fotos[3] == null ? Properties.Resources.remove : Image.FromFile(imovel.GetPathFoto(3));
            casa.Location = new Point(5, 5);
            casa.Margin = new Padding(0);
            casa.Name = "casa" + indexImovel.ToString();
            casa.Size = new Size(116, 128);
            casa.SizeMode = PictureBoxSizeMode.Zoom;

            ic1.Image = Properties.Resources.check;
            ic1.Location = new Point(0, 0);
            ic1.Margin = new Padding(0, 0, 4, 0);
            ic1.Name = "ic1" + indexImovel.ToString();
            ic1.Size = new Size(23, 35);
            ic1.SizeMode = PictureBoxSizeMode.CenterImage;

            ic2.Image = Properties.Resources.check;
            ic2.Location = new Point(0, 0);
            ic2.Margin = new Padding(0, 0, 4, 0);
            ic2.Name = "ic2" + indexImovel.ToString();
            ic2.Size = new Size(23, 35);
            ic2.SizeMode = PictureBoxSizeMode.CenterImage;

            ic3.Image = Properties.Resources.check;
            ic3.Location = new Point(0, 0);
            ic3.Margin = new Padding(0, 0, 4, 0);
            ic3.Name = "ic3" + indexImovel.ToString();
            ic3.Size = new Size(23, 35);
            ic3.SizeMode = PictureBoxSizeMode.CenterImage;

            editar.BackgroundImage = Properties.Resources.escrita;
            editar.BackgroundImageLayout = ImageLayout.Center;
            editar.Cursor = Cursors.Hand;
            editar.FlatAppearance.BorderColor = Color.White;
            editar.FlatAppearance.BorderSize = 0;
            editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            editar.FlatAppearance.MouseDownBackColor = Color.White;
            editar.FlatStyle = FlatStyle.Flat;
            editar.Location = new Point(462, 33);
            editar.Name = "editar" + indexImovel.ToString();
            editar.Size = new Size(32, 32);
            editar.BringToFront();

            excluir.BackgroundImage = Properties.Resources.x;
            excluir.BackgroundImageLayout = ImageLayout.Center;
            excluir.Cursor = Cursors.Hand;
            excluir.FlatAppearance.BorderColor = Color.White;
            excluir.FlatAppearance.BorderSize = 0;
            excluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            excluir.FlatStyle = FlatStyle.Flat;
            excluir.Location = new Point(503, 33);
            excluir.Name = "excluir" + indexImovel.ToString();
            excluir.Size = new Size(32, 32);
            excluir.BringToFront();

            flowLayoutPanel_ListaCasas.Controls.Add(bloco);
        }

        private float formatarLabel(Label l)
        {
            int tam = l.Text.Length;
            if (tam < 28)
            {
                return 17;
            }
            else if(tam < 32)
            {
                return 15;
            }
            else
            {
                return 13;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog(this);
            Imoveis.Add(add.Imovel);
        }
    }
}
