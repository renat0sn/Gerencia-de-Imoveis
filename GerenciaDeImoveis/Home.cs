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

        public void NovoBloco()
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog(this);
            Imoveis.Add(add.Imovel);
            Debug.WriteLine("close");
        }
    }
}
