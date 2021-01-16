using System;
using GerenciaDeImoveis.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciaDeImoveis
{
    public partial class Add : Form
    {
        public Imovel Imovel { get; set; }
        public string[] Images { get; set; }
        public Add()
        {
            InitializeComponent();
            Text = "Adicionar";
            Images = new string[7];
        }

        public Add(Imovel i)
        {
            InitializeComponent();
            Text = "Editar";
            Images = new string[7];
            for (int k = 0; k < 7; k++)
            {
                if (i.Fotos[k] != null)
                {
                    Button b = Controls.Find("btn" + k.ToString(), true)[0] as Button;
                    b.BackgroundImage = ExifRotate(Image.FromFile(i.GetPathFoto(k)));
                    b.BackgroundImageLayout = ImageLayout.Zoom;
                    Images[k] = i.Fotos[k];
                }
            }

            textBox_Endereco.Text = i.Endereco;
            comboBox_Bairro.SelectedIndex = (int)i.Bairro;
            textBox_Preco.Text = i.Preco.ToString("N2");
            numericUpDown_Terreno.Value = i.Terreno;
            numericUpDown_AreaConstruida.Value = i.AreaConstruida;
            numericUpDown_Garagens.Value = i.nGaragens;
            numericUpDown_Dormitorios.Value = i.nDormitorios;
            if (i.Estilo == Estilo.Térreo)
            {
                radioButton_Terreo.Checked = true;
            }
            else
            {
                radioButton_Sobrado.Checked = true;
            }
            if (i.Status == Status.Moderno)
            {
                radioButton_Moderno.Checked = true;
            }
            else
            {
                radioButton_Reforma.Checked = true;
            }
            if (i.Indicacao == Indicacao.Propria)
            {
                radioButton_Propria.Checked = true;
            }
            else
            {
                radioButton_Ricardo.Checked = true;
            }
            richTextBox_Observacoes.Text = i.Observacoes;
        }

        private void textBox_Preco_Click(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            if (T.Text == "0,00")
            {
                T.Text = "";
            }
        }

        private string FormatarParaMoeda(string s)
        {
            try
            {
                string moeda = s;
                int tam = s.Length;

                if (tam == 0)
                {
                    moeda = "";
                }
                moeda = moeda.PadLeft(2, '0');
                if (moeda.Length > 3 && moeda.Substring(0, 1) == "0")
                {
                    moeda = moeda.Substring(1, moeda.Length - 1);
                }
                double v = Convert.ToDouble(moeda) / 100;
                moeda = string.Format("{0:N}", v);
                return moeda;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Erro! " + e.Message, "Formato inválido");
                return "0,00";
            }
        }

        private void textBox_Preco_TextChanged(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            string value = T.Text.Replace(",", "").Replace(".", "");

            T.Text = FormatarParaMoeda(value);

            T.SelectionStart = T.Text.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Endereco.Equals("") || comboBox_Bairro.SelectedIndex == -1)
                {
                    throw new Exception("Alguns dos campos obrigatórios estão em branco.");
                }

                Imovel = new Imovel(
                    Images,
                    textBox_Endereco.Text,
                    (Bairro)comboBox_Bairro.SelectedIndex,
                    double.Parse(textBox_Preco.Text),
                    decimal.ToInt32(numericUpDown_Terreno.Value),
                    decimal.ToInt32(numericUpDown_AreaConstruida.Value),
                    decimal.ToInt32(numericUpDown_Garagens.Value),
                    decimal.ToInt32(numericUpDown_Dormitorios.Value),
                    richTextBox_Observacoes.Text,
                    radioButton_Terreo.Checked ? Estilo.Térreo : Estilo.Sobrado,
                    radioButton_Moderno.Checked ? Status.Moderno : Status.Precisa_de_reforma,
                    radioButton_Propria.Checked ? Indicacao.Propria : Indicacao.Ricardo
                 );

                Home h = Owner as Home;
                if (h.Imoveis.Any(im => im.Endereco == Imovel.Endereco) && this.Text == "Adicionar")
                {
                    throw new Exception("Lista já possui imóvel com mesmo endereço.");
                }

                if (MessageBox.Show("As informações estão corretas?\n\n" + Imovel.ToString(), "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    DialogResult = DialogResult.OK;
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex.Message, "Erro de entrada");
            }
        }

        private void SelecionarImagem(object sender, int key)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Filter = "Arquivos de imagem(*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Button btn = sender as Button;
                if (btn.Name == "btn3")
                {
                    HabilitarBotoes();
                }
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.BackgroundImageLayout = ImageLayout.Zoom;

                Image im = Image.FromFile(openFile.FileName);
                ExifRotate(im);
                string path = openFile.FileName;

                btn.BackgroundImage = im;

                Images[key] = "img" + key.ToString() + path;
            }
        }

        private void RemoverImagem(Button btn)
        {
            int index = GetIndexBtn(btn.Name);

            Images[index] = null;
            btn.BackgroundImageLayout = ImageLayout.Center;
            btn.BackgroundImage = Properties.Resources.mais32px_;
            Button b = Controls.Find("lixo" + index.ToString(), true)[0] as Button;
            b.Visible = false;
        }

        private int GetIndexBtn(string m)
        {
            return (int)char.GetNumericValue(m[3]);
        }

        private bool ExisteImagemNoBtn(Button b)
        {
            int index = GetIndexBtn(b.Name);
            return Images[index] != null;
        }

        private void DesabilitarBotoes()
        {

            btn0.Enabled = ExisteImagemNoBtn(btn0) ? true : false;
            btn1.Enabled = ExisteImagemNoBtn(btn1) ? true : false;
            btn2.Enabled = ExisteImagemNoBtn(btn2) ? true : false;
            btn4.Enabled = ExisteImagemNoBtn(btn4) ? true : false;
            btn5.Enabled = ExisteImagemNoBtn(btn5) ? true : false;
            btn6.Enabled = ExisteImagemNoBtn(btn6) ? true : false;
        }

        private void HabilitarBotoes()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
        }

        private void button_Hover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = (int)char.GetNumericValue(btn.Name[3]);

            if (Images[index] != null)
            {
                Button b = Controls.Find("lixo" + index.ToString(), true)[0] as Button;
                btn.BackColor = Color.Transparent;
                b.Visible = true;
            }
        }

        private void button_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = (int)char.GetNumericValue(btn.Name[3]);

            if (Images[index] != null)
            {
                Button b = Controls.Find("lixo" + index.ToString(), true)[0] as Button;
                b.Visible = false;
            }
        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            if (ExisteImagemNoBtn(btn))
            {
                if (MessageBox.Show("Deseja remover imagem?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    RemoverImagem(btn);
                    DesabilitarBotoes();
                }

            }
            else
            {
                SelecionarImagem(sender, GetIndexBtn(btn.Name));
            }
        }

        private const int exifOrientationID = 0x112; //274

        public static Image ExifRotate(Image img)
        {
            if (!img.PropertyIdList.Contains(exifOrientationID))
                return img;

            var prop = img.GetPropertyItem(exifOrientationID);
            int val = BitConverter.ToUInt16(prop.Value, 0);
            var rot = RotateFlipType.RotateNoneFlipNone;

            if (val == 3 || val == 4)
                rot = RotateFlipType.Rotate180FlipNone;
            else if (val == 5 || val == 6)
                rot = RotateFlipType.Rotate90FlipNone;
            else if (val == 7 || val == 8)
                rot = RotateFlipType.Rotate270FlipNone;

            if (val == 2 || val == 4 || val == 5 || val == 7)
                rot |= RotateFlipType.RotateNoneFlipX;

            if (rot != RotateFlipType.RotateNoneFlipNone)
                img.RotateFlip(rot);

            return img;
        }
    }
}
