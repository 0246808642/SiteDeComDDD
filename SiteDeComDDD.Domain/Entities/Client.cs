using System;


namespace SiteDeComDDD.Domain.Entities
{
    public class Client
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Client client)
        {
            return client.Ativo && DateTime.Now.Year - client.DataCadastro.Year >= 5;
        }
    }
}
