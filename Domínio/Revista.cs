namespace Clube_Leitura.Domínio
{
    class Revista
    {
        private string colecao;
        private int nro_edicao;
        private int ano;
        private Caixa caixa;

        public Revista(string colecao, int nro_edicao, int ano, Caixa caixa)
        {
            this.colecao = colecao;
            this.nro_edicao = nro_edicao;
            this.ano = ano;
            this.caixa = caixa;
        }

        internal Caixa Caixa { get => caixa; }

        public override bool Equals(object obj)
        {
            return obj is Revista revista &&
                   colecao == revista.colecao &&
                   nro_edicao == revista.nro_edicao;
        }

        public override int GetHashCode()
        {
            return nro_edicao.GetHashCode() ^ colecao.GetHashCode();
        }

        public override string ToString()
        {
            return "[Coleção: " + colecao + "/ Edição Número: " + nro_edicao + "/ Ano: " + ano + "/ Número Caixa: " + caixa.Numero + " ]";
        }
    }
}
