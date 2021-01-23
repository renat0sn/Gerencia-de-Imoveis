using System;
using System.Collections.Generic;
using GerenciaDeImoveis.Database;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
        public FileImovel File { get; set; }

        public Home()
        {
            InitializeComponent();
            File = new FileImovel();
            Imoveis = new List<Imovel>(File.LoadImoveis());
            LoadInitial();
        }

        public void LoadInitial()
        {
            foreach(Imovel i in Imoveis)
            {
                NovoBloco(i);
            }
        }

        public void NovoBloco(Imovel imovel)
        {
            int indexImovel = Imoveis.IndexOf(imovel);

            Panel bloco = new Panel();
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

            PictureBox ic1 = new PictureBox();
            PictureBox ic2 = new PictureBox();
            PictureBox ic3 = new PictureBox();

            Button editar = new Button();
            Button excluir = new Button();

            bloco.BorderStyle = BorderStyle.FixedSingle;
            bloco.Cursor = Cursors.Hand;
            bloco.Margin = new Padding(0,0,0,10);
            bloco.Name = "bloco";
            bloco.Padding = new Padding(0);
            bloco.Size = new Size(667, 140);
            bloco.Anchor = AnchorStyles.Top;
            bloco.Controls.Add(endereco);
            bloco.Controls.Add(bairro);
            bloco.Controls.Add(preco);
            bloco.Controls.Add(pInferior);
            bloco.MouseClick += Bloco_Click;

            pInferior.BorderStyle = BorderStyle.Fixed3D;
            pInferior.Location = new Point(-2, 70);
            pInferior.Name = "pInferior";
            pInferior.Size = new Size(bloco.Size.Width + 2, 69);
            pInferior.Margin = new Padding(0);
            pInferior.Controls.Add(f1);
            pInferior.Controls.Add(f2);
            pInferior.Controls.Add(f3);
            pInferior.Controls.Add(terrenoLabel);
            pInferior.Controls.Add(terrenoValue);
            pInferior.Controls.Add(areaLabel);
            pInferior.Controls.Add(areaValue);
            pInferior.Controls.Add(editar);
            pInferior.Controls.Add(excluir);
            pInferior.MouseClick += Bloco_Click;

            f1.Controls.Add(ic1);
            f1.Controls.Add(estilo);
            f1.Margin = new Padding(0);
            f1.Name = "f1";
            f1.Size = new Size(100, 35);
            f1.Location = new Point((bloco.Size.Width/2) - (f1.Size.Width/2), 0);
            f1.MouseClick += Bloco_Click;

            f2.Controls.Add(ic2);
            f2.Controls.Add(status);
            f2.Margin = new Padding(0);
            f2.Name = "f2";
            f2.Size = new Size(200, 35);
            f2.Location = new Point((bloco.Size.Width / 2) - (f1.Size.Width / 2), 32);
            f2.MouseClick += Bloco_Click;

            f3.Controls.Add(ic3);
            f3.Controls.Add(indicacao);
            f3.Location = new Point(491, 0);
            f3.Margin = new Padding(0);
            f3.Name = "f3";
            f3.Size = new Size(180, 35);
            f3.MouseClick += Bloco_Click;

            endereco.AutoSize = true;
            endereco.Location = new Point(20, 5);
            endereco.Margin = new Padding(0);
            endereco.Name = "endereco";
            endereco.Size = new Size(299, 33);
            endereco.Text = imovel.Endereco;
            endereco.Tag = "endereco";
            endereco.TextAlign = ContentAlignment.MiddleLeft;
            endereco.Font = formatarLabel(endereco, 470);
            endereco.MouseClick += Bloco_Click;

            bairro.AutoSize = true;
            bairro.Font = new Font("Gill Sans MT", 11F);
            bairro.Location = new Point(22, 38);
            bairro.Name = "bairro";
            bairro.Size = new Size(123, 21);
            bairro.Text = "(" + imovel.Bairro.ToString().Replace("_", " ") + ")";
            bairro.MouseClick += Bloco_Click;

            preco.Font = new Font("Gill Sans MT", 19F, FontStyle.Bold);
            preco.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            preco.Location = new Point(439, 0);
            preco.Margin = new Padding(0);
            preco.Name = "preco";
            preco.Size = new Size(223, 70);
            preco.Text = "R$" + imovel.Preco.ToString("N2");
            preco.TextAlign = ContentAlignment.MiddleRight;
            preco.MouseClick += Bloco_Click;

            terrenoLabel.Font = new Font("Gill Sans MT", 13F);
            terrenoLabel.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            terrenoLabel.Location = new Point(21, 0);
            terrenoLabel.Margin = new Padding(0);
            terrenoLabel.Name = "terrenoLabel";
            terrenoLabel.Size = new Size(78, 35);
            terrenoLabel.Text = "Terreno:";
            terrenoLabel.TextAlign = ContentAlignment.MiddleLeft;
            terrenoLabel.MouseClick += Bloco_Click;

            terrenoValue.Font = new Font("Gill Sans MT", 12F);
            terrenoValue.Location = new Point(98, 0);
            terrenoValue.Name = "terrenoValue";
            terrenoValue.Size = new Size(81, 35);
            terrenoValue.Text = imovel.Terreno.ToString() + " m²";
            terrenoValue.TextAlign = ContentAlignment.MiddleLeft;
            terrenoValue.MouseClick += Bloco_Click;

            areaLabel.Font = new Font("Gill Sans MT", 13F);
            areaLabel.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            areaLabel.Location = new Point(21, 32);
            areaLabel.Margin = new Padding(0);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(135, 35);
            areaLabel.Text = "Área construída:";
            areaLabel.TextAlign = ContentAlignment.MiddleLeft;
            areaLabel.MouseClick += Bloco_Click;

            areaValue.Font = new Font("Gill Sans MT", 12F);
            areaValue.Location = new Point(154, 32);
            areaValue.Name = "areaValue";
            areaValue.Size = new Size(67, 35);
            areaValue.Text = imovel.AreaConstruida.ToString() + " m²";
            areaValue.TextAlign = ContentAlignment.MiddleLeft;
            areaValue.MouseClick += Bloco_Click;

            estilo.AutoSize = true;
            estilo.Font = new Font("Gill Sans MT", 12F);
            estilo.Location = new Point(27, 6);
            estilo.Margin = new Padding(0, 0, 3, 0);
            estilo.Name = "estilo";
            estilo.Size = new Size(64, 23);
            estilo.Text = imovel.Estilo.ToString();
            estilo.TextAlign = ContentAlignment.MiddleLeft;
            estilo.MouseClick += Bloco_Click;

            status.AutoSize = true;
            status.Font = new Font("Gill Sans MT", 12F);
            status.Location = new Point(27, 6);
            status.Margin = new Padding(0, 0, 3, 0);
            status.Name = "status";
            status.Size = new Size(132, 23);
            status.Text = imovel.Status.ToString().Replace("_", " ");
            status.TextAlign = ContentAlignment.MiddleLeft;
            status.MouseClick += Bloco_Click;

            indicacao.AutoSize = true;
            indicacao.Font = new Font("Gill Sans MT", 12F);
            indicacao.Location = new Point(27, 6);
            indicacao.Margin = new Padding(0, 0, 3, 0);
            indicacao.Name = "indicacao";
            indicacao.Size = new Size(147, 23);
            indicacao.Text = "Indicação: " + imovel.Indicacao.ToString().Replace("_", " ");
            indicacao.TextAlign = ContentAlignment.MiddleLeft;
            indicacao.MouseClick += Bloco_Click;

            ic1.Image = Properties.Resources.check;
            ic1.Location = new Point(0, 0);
            ic1.Margin = new Padding(0, 0, 4, 0);
            ic1.Name = "ic1";
            ic1.Size = new Size(23, 35);
            ic1.SizeMode = PictureBoxSizeMode.CenterImage;
            ic1.MouseClick += Bloco_Click;

            ic2.Image = Properties.Resources.check;
            ic2.Location = new Point(0, 0);
            ic2.Margin = new Padding(0, 0, 4, 0);
            ic2.Name = "ic2";
            ic2.Size = new Size(23, 35);
            ic2.SizeMode = PictureBoxSizeMode.CenterImage;
            ic2.MouseClick += Bloco_Click;

            ic3.Image = Properties.Resources.check;
            ic3.Location = new Point(120, 0);
            ic3.Margin = new Padding(0, 0, 4, 0);
            ic3.Name = "ic3";
            ic3.Size = new Size(23, 35);
            ic3.SizeMode = PictureBoxSizeMode.CenterImage;
            ic3.MouseClick += Bloco_Click;

            editar.BackgroundImage = Properties.Resources.escrita;
            editar.BackgroundImageLayout = ImageLayout.Center;
            editar.Cursor = Cursors.Hand;
            editar.FlatAppearance.BorderColor = Color.White;
            editar.FlatAppearance.BorderSize = 0;
            editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            editar.FlatAppearance.MouseDownBackColor = Color.White;
            editar.FlatStyle = FlatStyle.Flat;
            editar.Location = new Point(580, 33);
            editar.Name = "editar";
            editar.Size = new Size(32, 32);
            editar.Click += Editar_Click;
            editar.BringToFront();

            excluir.BackgroundImage = Properties.Resources.x;
            excluir.BackgroundImageLayout = ImageLayout.Center;
            excluir.Cursor = Cursors.Hand;
            excluir.FlatAppearance.BorderColor = Color.White;
            excluir.FlatAppearance.BorderSize = 0;
            excluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            excluir.FlatStyle = FlatStyle.Flat;
            excluir.Location = new Point(615, 33);
            excluir.Name = "excluir";
            excluir.Size = new Size(32, 32);
            excluir.BringToFront();
            excluir.Click += Excluir_Click;

            flowLayoutPanel_ListaCasas.Controls.Add(bloco);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Panel p = (sender as Button).Parent.Parent as Panel;
            Imovel ant = GetImovelByPanel(p);
            using (Add edit = new Add(ant))
            {
                if (edit.ShowDialog(this) == DialogResult.OK)
                {
                    int index = Imoveis.IndexOf(GetImovelByPanel(p));
                    Imoveis[index] = edit.Imovel;
                    UpdateBloco(p, edit.Imovel);
                    File.AtualizarImovel(ant, edit.Imovel);
                    
                }
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Panel p = (sender as Button).Parent.Parent as Panel;
            Imovel i = GetImovelByPanel(p);

            if (MessageBox.Show(i.Endereco + "\n\nDeseja excluir o imóvel?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoverBloco(p, i);
            }
        }

        public void RemoverBloco(Panel bloco, Imovel imovel)
        {
            flowLayoutPanel_ListaCasas.Controls.Remove(bloco);
            Imoveis.Remove(imovel);
            File.ExcluirImovel(imovel);
        }

        public void UpdateBloco (Panel bloco, Imovel imovel)
        {
            Label endereco = bloco.Controls.Find("endereco", true)[0] as Label;
            Label bairro = bloco.Controls.Find("bairro", true)[0] as Label;
            Label preco = bloco.Controls.Find("preco", true)[0] as Label;
            Label terrenoValue = bloco.Controls.Find("terrenoValue", true)[0] as Label;
            Label areaValue = bloco.Controls.Find("areaValue", true)[0] as Label;
            Label estilo = bloco.Controls.Find("estilo", true)[0] as Label;
            Label status = bloco.Controls.Find("status", true)[0] as Label;
            Label indicacao = bloco.Controls.Find("indicacao", true)[0] as Label;

            endereco.Text = imovel.Endereco;
            endereco.Font = formatarLabel(endereco, 470);
            bairro.Text = "(" + imovel.Bairro.ToString().Replace("_", " ") + ")";
            preco.Text = "R$" + imovel.Preco.ToString("N2");
            terrenoValue.Text = imovel.Terreno.ToString() + " m²";
            areaValue.Text = imovel.AreaConstruida.ToString() + " m²";
            estilo.Text = imovel.Estilo.ToString();
            status.Text = imovel.Status.ToString().Replace("_", " ");
            indicacao.Text = indicacao.Text = "Indicação: " + imovel.Indicacao.ToString().Replace("_", " ");
        }

        private void Bloco_Click(object sender, MouseEventArgs e)
        {
            using (Detalhes det = new Detalhes(GetImovelByObject(sender)))
            {
                det.ShowDialog();
            }
        }

        private Imovel GetImovelByObject(object obj)
        {
            Control control = obj as Control;
            while(control.Name != "bloco")
            {
                control = control.Parent;
            }
            return GetImovelByPanel(control as Panel);
        }

        private Imovel GetImovelByPanel(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c.Tag.ToString() == "endereco")
                {
                    Label l = c as Label;
                    return Imoveis.Where(im => im.Endereco == l.Text).FirstOrDefault();
                }
            }
            return null;
        }

        private Font formatarLabel(Label l, int tamContainer)
        {
            float f = 17;
            Font font = new Font("Gill Sans MT", f);
            Size s = TextRenderer.MeasureText(l.Text, font);

            while (s.Width > tamContainer)
            {
                f -= 0.5F;
                font = new Font(l.Font.Name, f);
                s = TextRenderer.MeasureText(l.Text, font);
            }

            return font;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (Add add = new Add())
            {
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    Imoveis.Add(add.Imovel);
                    NovoBloco(add.Imovel);
                    File.AddImovel(add.Imovel);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Imovel i in Imoveis)
            {
                Debug.WriteLine("Index: " + Imoveis.IndexOf(i).ToString() + " | " + i.Endereco);
            }
            Debug.WriteLine("\n");
        }

        private void button_Busca_Click(object sender, EventArgs e)
        {
            string busca = textBox_Busca.Text;
            if(busca != "")
            {
                newButton_Limpar();
                flowLayoutPanel_ListaCasas.Controls.Clear();
                foreach(Imovel i in Imoveis)
                {
                    if (i.BuscaValida(busca))
                    {
                        NovoBloco(i);
                    }
                }
            }
        }

        private void newButton_Limpar()
        {
            if(splitContainerPrincipal.Panel2.Controls["button_Limpar"] == null)
            {
                Button limpar = new Button();

                limpar.Name = "button_Limpar";
                limpar.Location = new Point((splitContainerPrincipal.Panel2.Width / 2) - 80, 90);
                limpar.Size = new Size(160, 30);
                limpar.Anchor = AnchorStyles.Top;
                limpar.Text = "Limpar filtro";
                limpar.BackColor = Color.PaleTurquoise;
                limpar.Font = new Font("Gill Sans MT", 11);
                limpar.MouseClick += Limpar_MouseClick;

                splitContainerPrincipal.Panel2.Controls.Add(limpar);
            }
        }

        private void Limpar_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainerPrincipal.Panel2.Controls.Remove(sender as Control);
            textBox_Busca.Clear();
            flowLayoutPanel_ListaCasas.Controls.Clear();
            LoadInitial();
        }
    }
}
