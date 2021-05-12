namespace Clube_Leitura.Domínio
{
    class Amiguinho
    {
        private string nome;
        private string nome_responsavel;
        private string telefone;
        private string bairro;

        public Amiguinho(string nome, string nome_responsavel, string telefone, string bairro)
        {
            this.nome = nome;
            this.nome_responsavel = nome_responsavel;
            this.telefone = telefone;
            this.bairro = bairro;
        }

        public string Nome { get => nome; }

        public override bool Equals(object obj)
        {
            return obj is Amiguinho amiguinho && telefone == amiguinho.telefone;
        }

        public override int GetHashCode()
        {
            return telefone.GetHashCode() ^ nome.GetHashCode();
        }

        public override string ToString()
        {
            return "[Nome: " + nome + "/ Telefone: " + telefone + "/ Bairro: " + bairro + " ]";
        }
    }
}
