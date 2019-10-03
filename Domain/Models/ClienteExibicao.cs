namespace SqImport.Domain.Models
{
    public class ClienteExibicao
    {
        public string Nome { get; set; }
        public string Regiao { get; set; }
        public int Idade { get; set; }
        public int MedalhasOuro { get; set; }
        public int MedalhasPrata { get; set; }
        public int MedalhasBronze { get; set; }
        public double Desconto { get; set; }

        public ClienteExibicao(
            string nome,
            string regiao,
            int idade,
            int medalhasOuro,
            int medalhasPrata,
            int medalhasBronze,
            double desconto
        )
        {
            Nome = nome;
            Regiao = regiao;
            Idade = idade;
            MedalhasOuro = medalhasOuro;
            MedalhasPrata = medalhasPrata;
            MedalhasBronze = medalhasBronze;
            Desconto = desconto;
        }
    }
}