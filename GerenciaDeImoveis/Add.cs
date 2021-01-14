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
        public Add()
        {
            InitializeComponent();
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
                    textBox_Endereco.Text,
                    (Bairro)comboBox_Bairro.SelectedIndex,
                    double.Parse(textBox_Preco.Text.Replace(",", "").Replace(".", "")),
                    decimal.ToInt32(numericUpDown_Terreno.Value),
                    decimal.ToInt32(numericUpDown_AreaConstruida.Value),
                    decimal.ToInt32(numericUpDown_Garagens.Value),
                    decimal.ToInt32(numericUpDown_Dormitorios.Value),
                    richTextBox_Observacoes.Text,
                    radioButton_Terreo.Checked ? Estilo.Térreo : Estilo.Sobrado,
                    radioButton_Moderno.Checked ? Status.Moderno : Status.Precisa_de_reforma,
                    radioButton_Propria.Checked ? Indicacao.Propria : Indicacao.Ricardo
                 );

                DialogResult = MessageBox.Show("As informações estão corretas?\n\n" + Imovel.ToString(), "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (DialogResult == DialogResult.Yes)
                {
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
