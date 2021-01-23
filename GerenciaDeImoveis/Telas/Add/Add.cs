using System;
using GerenciaDeImoveis.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GerenciaDeImoveis
{
    public partial class Add : Form
    {
        public Imovel Imovel { get; set; }

        public Add()
        {
            InitializeComponent();
            Text = "Adicionar";
        }

        public Add(Imovel i)
        {
            InitializeComponent();
            Text = "Editar";

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
                    textBox_Endereco.Text,
                    (Bairro)comboBox_Bairro.SelectedIndex,
                    double.Parse(textBox_Preco.Text),
                    decimal.ToInt32(numericUpDown_Terreno.Value),
                    decimal.ToInt32(numericUpDown_AreaConstruida.Value),
                    decimal.ToInt32(numericUpDown_Garagens.Value),
                    decimal.ToInt32(numericUpDown_Dormitorios.Value),
                    richTextBox_Observacoes.Text.Replace("\n", @"\n"),
                    radioButton_Terreo.Checked ? Estilo.Térreo : Estilo.Sobrado,
                    radioButton_Moderno.Checked ? Status.Moderno : Status.Precisa_de_reforma,
                    radioButton_Propria.Checked ? Indicacao.Propria : Indicacao.Ricardo
                 );

                Home h = Owner as Home;
                if (h.Imoveis.Any(im => im.Endereco == Imovel.Endereco) && Text == "Adicionar")
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
    }
}
