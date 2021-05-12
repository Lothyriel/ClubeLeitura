namespace Clube_Leitura.Domínio
{
    class Caixa
    {
        private string cor;
        private string etiqueta;
        private int numero;

        public Caixa(string cor, string etiqueta, int numero)
        {
            this.cor = cor;
            this.etiqueta = etiqueta;
            this.numero = numero;
        }
        public int Numero { get => numero;}

        public override bool Equals(object obj)
        {
            return obj is Caixa caixa && numero == caixa.numero;
        }

        public override int GetHashCode()
        {
            return numero.GetHashCode() ^ etiqueta.GetHashCode();
        }
        public override string ToString()
        {
            return "[Número: " + numero + "/ Etiqueta: " + etiqueta + "/ Cor: " + cor + " ]";
        }
    }
}
