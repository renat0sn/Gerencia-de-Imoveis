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
        public List<Imovel> ImoveisLoad { get; set; }
        public FileImovel File { get; set; }
        public int Pagina { get; set; }

        public Home()
        {
            InitializeComponent();
            File = new FileImovel();
            Pagina = 1;
            Imoveis = new List<Imovel>(File.LoadImoveis());
            ImoveisLoad = Imoveis;
            LoadImoveis(ImoveisLoad, Pagina);
            ZerarFiltros();
        }

        public void LoadImoveis(List<Imovel> imoveis, int index)
        {
            int imoveisPorPagina = 10;

            flowLayoutPanel_ListaCasas.SuspendLayout();
            flowLayoutPanel_ListaCasas.Controls.Clear();

            ImoveisLoad = imoveis;

            Pagina = index;

            int inicio = (Pagina * imoveisPorPagina) - imoveisPorPagina;
            int fim = (Pagina * imoveisPorPagina);

            if (Pagina <= 0)
            {
                inicio = 1;
            }

            else if (fim >= imoveis.Count)
            {
                fim = imoveis.Count - 1;
            }

            if (imoveis.Count > inicio)
            {
                for(int k=inicio; k<fim; k++)
                {
                    NovoBloco(imoveis[k]);
                }
            }

            label_Pagina.Text = "Página " + Pagina + " de " + ((imoveis.Count / imoveisPorPagina) + 1);
            flowLayoutPanel_ListaCasas.ResumeLayout();
        }

        public void NovoBloco(Imovel imovel)
        {
            ImovelBox ib = new ImovelBox(imovel);
            ib.MouseClick += Bloco_Click;
            flowLayoutPanel_ListaCasas.Controls.Add(new ImovelBox(imovel));
        }

        public void Editar_Click(object sender, EventArgs e)
        {
            Imovel ant = (sender as ImovelBox).Imovel;
            using (Add edit = new Add(ant))
            {
                if (edit.ShowDialog(this) == DialogResult.OK)
                {
                    int index = Imoveis.IndexOf(ant);
                    Imoveis[index] = edit.Imovel;
                    UpdateBloco((sender as ImovelBox), edit.Imovel);
                    File.AtualizarImovel(ant, edit.Imovel);
                }
            }
        }

        public void Excluir_Click(object sender, EventArgs e)
        {
            Imovel i = (sender as ImovelBox).Imovel;

            if (MessageBox.Show(i.Endereco + "\n\nDeseja excluir o imóvel?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoverBloco(sender as ImovelBox, i);
            }
        }

        public void RemoverBloco(ImovelBox bloco, Imovel imovel)
        {
            flowLayoutPanel_ListaCasas.Controls.Remove(bloco);
            Imoveis.Remove(imovel);
            LoadImoveis(Imoveis, Pagina);
            File.ExcluirImovel(imovel);
        }

        public void UpdateBloco(ImovelBox bloco, Imovel i)
        {
            bloco.Imovel = i;

            Label endereco = bloco.endereco;
            Label bairro = bloco.bairro;
            Label preco = bloco.preco;
            Label terrenoValue = bloco.terreno;
            Label areaValue = bloco.areaconstruida;
            Label estilo = bloco.estilo;
            Label status = bloco.status;
            Label indicacao = bloco.indicacao;

            endereco.Text = i.Endereco;
            bairro.Text = "(" + i.Bairro.ToString().Replace("_", " ") + ")";
            preco.Text = "R$" + i.Preco.ToString("N2");
            terrenoValue.Text = i.Terreno.ToString() + " m²";
            areaValue.Text = i.AreaConstruida.ToString() + " m²";
            estilo.Text = i.Estilo.ToString();
            status.Text = i.Status.ToString().Replace("_", " ");
            indicacao.Text = indicacao.Text = "Indicação: " + i.Indicacao.ToString().Replace("_", " ");
        }

        public void Bloco_Click(object sender, MouseEventArgs e)
        {
            using (Detalhes det = new Detalhes((sender as ImovelBox).Imovel))
            {
                det.ShowDialog();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (Add add = new Add())
            {
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    Imoveis.Insert(0, add.Imovel);

                    File.AddImovel(add.Imovel);

                    LoadImoveis(Imoveis.ToList(), 1);
                }
            }
        }

        private void button_Busca_Click(object sender, EventArgs e)
        {
            List<Imovel> imoveis = new List<Imovel>();
            string busca = textBox_Busca.Text;
            if (busca != "")
            {
                newButton_Limpar();
                foreach (Imovel i in Imoveis)
                {
                    if (i.BuscaValida(busca))
                    {
                        imoveis.Add(i);
                    }
                }
                ImoveisLoad = imoveis;
                LoadImoveis(imoveis, 1);
            }
        }

        private void newButton_Limpar()
        {
            if (panel1_Busca.Controls["button_Limpar"] == null)
            {
                Button limpar = new Button();

                limpar.Name = "button_Limpar";
                limpar.Location = new Point((panel1_Busca.Width / 2) - 80, 85);
                limpar.Size = new Size(160, 30);
                limpar.Anchor = AnchorStyles.Left;
                limpar.Text = "Desativar filtro";
                limpar.BackColor = Color.PaleTurquoise;
                limpar.Font = new Font("Gill Sans MT", 11);
                limpar.MouseClick += Limpar_MouseClick;

                panel1_Busca.Controls.Add(limpar);
            }
        }

        private void Limpar_MouseClick(object sender, MouseEventArgs e)
        {
            panel1_Busca.Controls.Remove(sender as Control);
            textBox_Busca.Clear();
            flowLayoutPanel_ListaCasas.Controls.Clear();
            ImoveisLoad = Imoveis;
            LoadImoveis(Imoveis, 1);
        }

        private void trackBarMinimo_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBarMin = sender as TrackBar;
            GroupBox groupBox = trackBarMin.Parent as GroupBox;
            TrackBar trackBarMax = groupBox.Controls["trackBar_ValorMaximoPreco"] as TrackBar;
            Label trackLabelMin = groupBox.Controls["label_ValorMinimoPreco"] as Label;

            if (groupBox.Name == "groupBox_Preco")
            {
                trackLabelMin.Text = "R$ " + (TrackBarValueToPreco(trackBarMin.Value)).ToString("N2");
            }

            if (trackBarMin.Value > trackBarMax.Value)
            {
                trackBarMax.Value = trackBarMin.Value;
            }

            if (trackBarMin.Value == trackBarMin.Maximum)
            {
                trackLabelMin.Text = "Máximo";
            }
            else if (trackBarMin.Value == trackBarMin.Minimum)
            {
                trackLabelMin.Text = "Mínimo";
            }
        }

        private void trackBarMaximo_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBarMax = sender as TrackBar;
            GroupBox groupBox = trackBarMax.Parent as GroupBox;
            TrackBar trackBarMin = groupBox.Controls["trackBar_ValorMinimoPreco"] as TrackBar;
            Label trackLabelMax = groupBox.Controls["label_ValorMaximoPreco"] as Label;

            trackLabelMax.Text = "R$ " + (TrackBarValueToPreco(trackBarMax.Value)).ToString("N2");

            if (trackBarMax.Value < trackBarMin.Value)
            {
                trackBarMin.Value = trackBarMax.Value;
            }

            if (trackBarMax.Value == trackBarMax.Maximum)
            {
                trackLabelMax.Text = "Máximo";
            }
            else if (trackBarMax.Value == trackBarMax.Minimum)
            {
                trackLabelMax.Text = "Mínimo";
            }
        }

        private double TrackBarValueToPreco(int value)
        {
            return 100000 * value;
        }

        private void button_AplicarFiltros(object sender, EventArgs e)
        {
            List<Bairro> bairros = new List<Bairro>();
            foreach (CheckBox c in panel_Bairros.Controls)
            {
                if (c.Checked)
                {
                    bairros.Add((Bairro)Enum.Parse(typeof(Bairro), c.Name));
                }

            }

            (double, double) preco = (TrackBarValueToPreco(trackBar_ValorMinimoPreco.Value), trackBar_ValorMaximoPreco.Value == trackBar_ValorMaximoPreco.Maximum ? double.MaxValue : TrackBarValueToPreco(trackBar_ValorMaximoPreco.Value));

            (int, int) terreno = (int.Parse(comboBox1.SelectedItem.ToString()), int.Parse(comboBox2.SelectedItem.ToString()));

            (int, int) area = (int.Parse(comboBox3.SelectedItem.ToString()), int.Parse(comboBox4.SelectedItem.ToString()));

            Estilo? casa;
            if (radioButton1.Checked)
            {
                casa = (Estilo)Enum.Parse(typeof(Estilo), radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                casa = (Estilo)Enum.Parse(typeof(Estilo), radioButton2.Text);
            }
            else
            {
                casa = null;
            }

            Pagina = 1;
            newButton_Limpar();
            LoadImoveis(FiltrarImoveis(bairros, preco, terreno, area, casa), 1);
        }

        private List<Imovel> FiltrarImoveis(List<Bairro> bairros, (double, double) preco, (int, int) terreno, (int, int) area, Estilo? casa)
        {
            List<Imovel> imoveisSelecao = Imoveis;

            if (bairros.Count != 0 && bairros.Count < Enum.GetValues(typeof(Bairro)).Length)
            {
                imoveisSelecao = new List<Imovel>();
                foreach (Bairro b in bairros)
                {
                    imoveisSelecao.AddRange(Imoveis.Intersect(Imoveis.Where(i => i.Bairro == b)));
                }
            }

            imoveisSelecao = imoveisSelecao.Intersect(Imoveis.Where(i =>
            i.Preco >= preco.Item1 && i.Preco <= preco.Item2
            && i.Terreno >= terreno.Item1 && i.Terreno <= terreno.Item2
            && i.AreaConstruida >= area.Item1 && i.AreaConstruida <= area.Item2)).ToList();

            if (casa != null)
            {
                imoveisSelecao = imoveisSelecao.Intersect(Imoveis.Where(i => i.Estilo == casa)).ToList();
            }

            return imoveisSelecao;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > comboBox2.SelectedIndex)
            {
                comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < comboBox1.SelectedIndex)
            {
                comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > comboBox4.SelectedIndex)
            {
                comboBox4.SelectedIndex = comboBox3.SelectedIndex;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex < comboBox3.SelectedIndex)
            {
                comboBox3.SelectedIndex = comboBox4.SelectedIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZerarFiltros();
        }

        private void ZerarFiltros()
        {
            foreach (CheckBox checkbox in panel_Bairros.Controls)
            {
                checkbox.Checked = false;
            }

            trackBar_ValorMinimoPreco.Value = trackBar_ValorMinimoPreco.Minimum;
            trackBar_ValorMaximoPreco.Value = trackBar_ValorMaximoPreco.Maximum;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = comboBox4.Items.Count - 1;

            radioButton3.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Pagina < (ImoveisLoad.Count/10) + 1)
            {
                LoadImoveis(ImoveisLoad, Pagina+1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Pagina > 1)
            {
                LoadImoveis(ImoveisLoad, Pagina-1);
            }
        }
    }
}
