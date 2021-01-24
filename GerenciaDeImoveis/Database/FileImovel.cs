using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GerenciaDeImoveis.Model;
using System.Diagnostics;

namespace GerenciaDeImoveis.Database
{
    public class FileImovel
    {
        public string Caminho { get; set; }
        public DirectoryInfo Diretorio { get; set; }

        public FileImovel()
        {
            Diretorio = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "imovel_data"));
            Caminho = Path.Combine(Diretorio.FullName, "Data.txt");

            if (!File.Exists(Caminho))
            {
                File.Create(Caminho).Dispose();
            }
        }

        private Imovel ConvertStringToImovel(string s)
        {
            Imovel i;
            string[] param = s.Split(';');
            string endereco = param[0];
            Bairro bairro = (Bairro)(int.Parse(param[1]));
            double preco = double.Parse(param[2]);
            int terreno = int.Parse(param[3]);
            int area = int.Parse(param[4]);
            int garagens = int.Parse(param[5]);
            int dorm = int.Parse(param[6]);
            string observ = param[7].Replace(@"\n", "\n");
            Estilo estilo = (Estilo)(int.Parse(param[8]));
            Status status = (Status)(int.Parse(param[9]));
            Indicacao indicacao = (Indicacao)(int.Parse(param[10]));

            i = new Imovel(endereco, bairro, preco, terreno, area, garagens, dorm, observ, estilo, status, indicacao);
            return i;
        }

        private string ConvertImovelToString(Imovel i)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(i.Endereco + ";");
            sb.Append((int)i.Bairro + ";");
            sb.Append(i.Preco + ";");
            sb.Append(i.Terreno + ";");
            sb.Append(i.AreaConstruida + ";");
            sb.Append(i.nGaragens + ";");
            sb.Append(i.nDormitorios + ";");
            sb.Append(i.Observacoes.Replace(";", ".").Replace("\n", @"\n") + ";");
            sb.Append((int)i.Estilo + ";");
            sb.Append((int)i.Status + ";");
            sb.Append((int)i.Indicacao + ";");

            return sb.ToString();
        }

        public List<Imovel> LoadImoveis()
        {
            List<Imovel> imoveis = new List<Imovel>();

            string[] s = File.ReadAllLines(Caminho, Encoding.UTF8);
            foreach (string line in s)
            {
                if(!line.Equals(""))
                {
                    imoveis.Add(ConvertStringToImovel(line));
                }
            }

            return imoveis;
        }

        public void AddImovel(Imovel i)
        {
            string s = ConvertImovelToString(i);

            File.AppendAllText(Caminho, s + "\n");
        }

        public void ExcluirImovel(Imovel i)
        {
            string s = ConvertImovelToString(i);
            StringBuilder newText = new StringBuilder();

            using (StreamReader sr = new StreamReader(Caminho, Encoding.UTF8))
            {
                string aux;
                while (!sr.EndOfStream)
                {
                    aux = sr.ReadLine();
                    if (aux != s && aux != "")
                    {
                        newText.Append(aux + "\n");
                    }
                }
            }
            File.WriteAllText(Caminho, newText.ToString());
        }

        public void AtualizarImovel(Imovel anterior, Imovel novo)
        {
            string ant = ConvertImovelToString(anterior);
            string d = ConvertImovelToString(novo);

            string text = File.ReadAllText(Caminho).Replace(ant, d);
            File.WriteAllText(Caminho, text);
        }
    }
}
