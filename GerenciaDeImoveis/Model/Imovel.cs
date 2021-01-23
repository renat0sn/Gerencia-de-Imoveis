namespace GerenciaDeImoveis.Model
{
    public class Imovel
    {
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

        public Imovel(string endereco, Bairro bairro, double preco, int terreno, int areaConstruida, int nGaragens, int nDormitorios, string observacoes, Estilo estilo, Status status, Indicacao indicacao)
        {
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

        public override string ToString()
        {
            string msg = "Endereço: " + Endereco
                + "\nBairro: " + Bairro.ToString().Replace('_', ' ')
                + "\nPreço: R$" + Preco.ToString("N2")
                + "\nTerreno: " + Terreno + " m2"
                + "\nÁrea construída: " + AreaConstruida + " m2"
                + "\nNúmero de garagens: " + nGaragens
                + "\nNúmero de dormitórios: " + nDormitorios
                + "\nEstilo: " + Estilo.ToString()
                + "\nStatus: " + Status.ToString().Replace('_', ' ')
                + "\nIndicação: " + Indicacao.ToString()
                + "\nObservações: \n" + Observacoes.Replace(@"\n", "\n");
            return msg;
        }

        public bool BuscaValida(string s)
        {
            string sLower = s.ToLower();
            return Endereco.ToLower().Contains(sLower)
                || Bairro.ToString().Replace("_", " ").ToLower().Contains(sLower)
                || Preco.ToString("N2").Contains(sLower)
                || Terreno.ToString().Contains(sLower)
                || AreaConstruida.ToString().Contains(sLower)
                || nGaragens.ToString().Contains(sLower)
                || nDormitorios.ToString().Contains(sLower)
                || Observacoes.ToLower().Contains(sLower)
                || Estilo.ToString().ToLower().Contains(sLower)
                || Status.ToString().ToLower().Replace("_", " ").Contains(sLower)
                || Indicacao.ToString().ToLower().Contains(sLower);
        }
    }
}
