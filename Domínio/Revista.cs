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

        public override string ToString()
        {
            return "[Coleção: " + colecao + "/ Edição Número: " + nro_edicao + "/ Ano: " + ano + "/ Número Caixa: " + caixa.Numero + " ]";
        }
    }
}
