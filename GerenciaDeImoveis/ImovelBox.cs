using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciaDeImoveis.Model;
using GerenciaDeImoveis.Database;

namespace GerenciaDeImoveis
{
    public partial class ImovelBox : UserControl
    {
        public Imovel Imovel { get; set; }
        public ImovelBox(Imovel i)
        {
            InitializeComponent();
            Imovel = i;
            DoubleBuffered = true;
            endereco.Text = i.Endereco;
            endereco.Font = ExtensionMethods.formatarLabel(endereco, 470);
            bairro.Text = "(" + i.Bairro.ToString().Replace("_", " ") + ")";
            preco.Text = "R$ " + i.Preco.ToString("N2");
            terreno.Text = i.Terreno.ToString() + " m²";
            areaconstruida.Text = i.AreaConstruida.ToString() + " m²";
            estilo.Text = i.Estilo.ToString();
            status.Text = i.Status.ToString().Replace("_", " ");
            indicacao.Text = "Indicação: " + i.Indicacao.ToString();
        }

        public void button1_MouseClick(object sender, MouseEventArgs e)
        {
            (ParentForm as Home).Editar_Click(this, e);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            (ParentForm as Home).Excluir_Click(this, e);
        }

        private void ImovelBox_MouseClick(object sender, MouseEventArgs e)
        {
            (ParentForm as Home).Bloco_Click(this, e);
        }
    }
}
