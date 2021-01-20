using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaDeImoveis.Model
{
    public class Imovel
    {
        public string[] Fotos { get; set; }
        public string Endereco { get; set; }
        public Bairro Bairro { get; set; }
        public double Preco { get; set; }
        public int Terreno { get; set; }
        public int AreaConstruida { get; set; }
        public int nGaragens { get; set; }
        public int nDormitorios { get; set; }
        public string Observacoes { get; set; }
        public Estilo Estilo { get; set; }
        public Status Status { get; set; }
        public Indicacao Indicacao { get; set; }

        public Imovel(string[] fotos, string endereco, Bairro bairro, double preco, int terreno, int areaConstruida, int nGaragens, int nDormitorios, string observacoes, Estilo estilo, Status status, Indicacao indicacao)
        {
            Fotos = new string[7] { "", "", "", "", "", "", "" };
            Fotos = fotos;
            Endereco = endereco;
            Bairro = bairro;
            Preco = preco;
            Terreno = terreno;
            AreaConstruida = areaConstruida;
            this.nGaragens = nGaragens;
            this.nDormitorios = nDormitorios;
            Observacoes = observacoes;
            Estilo = estilo;
            Status = status;
            Indicacao = indicacao;
        }

        public string GetPathFoto(int index)
        {
            return Fotos[index].Equals("") ? "" : Fotos[index].Substring(4);
        }

        public string GetFotos()
        {
            string dir = "";
            for(int i = 0; i<Fotos.Length; i++)
            {
                dir += Fotos[i] != "" ? (Fotos[i].Substring(4) + "\n") : "";
            }
            return dir;
        }

        public override string ToString()
        {
            string msg =
                "Imagens: \n" + GetFotos() 
                + "\nEndereço: " + Endereco
                + "\nBairro: " + Bairro.ToString().Replace('_', ' ')
                + "\nPreço: R$" + Preco.ToString("N2")
                + "\nTerreno: " + Terreno + " m2"
                + "\nÁrea construída: " + AreaConstruida + " m2"
                + "\nNúmero de garagens: " + nGaragens
                + "\nNúmero de dormitórios: " + nDormitorios
                + "\nEstilo: " + Estilo.ToString()
                + "\nStatus: " + Status.ToString().Replace('_', ' ')
                + "\nIndicação: " + Indicacao.ToString()
                + "\nObservações: \n" + Observacoes;
            return msg;
        }
    }
}
