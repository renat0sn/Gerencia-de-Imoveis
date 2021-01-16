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
            Images = new string[7];
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
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

                if(MessageBox.Show("As informações estão corretas?\n\n" + Imovel.ToString(), "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Home h = Owner as Home;
                    h.NovoBloco(Imovel);
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
                if(btn.Name == "btn3")
                {
                    HabilitarBotoes();
                }
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                
                Image im = Image.FromFile(openFile.FileName);
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

            btn0.Enabled = ExisteImagemNoBtn(btn0) ? true : false ;
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

            if(Images[index] != null)
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
                if(MessageBox.Show("Deseja remover imagem?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
    }
}
