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
        public override string ToString()
        {
            return "[Número: " + numero + "/ Etiqueta: " + etiqueta + "/ Cor: " + cor + " ]";
        }
    }
}
