using Clube_Leitura.Domínio;

namespace Clube_Leitura.Controladores
{
    class ControladorCaixas : Controlador
    {
        private int indiceCaixa;

        public ControladorCaixas()
        {
            indiceCaixa = 0;
        }

        public int IndiceCaixa { get => ++indiceCaixa;}

        /*public override void excluir(int indice)
        {
            int i = 0;

            foreach (Caixa c in registros )
            {
                if (i == c.Numero) { break; }
                i++;
            }
            base.excluir(indice);
        */}
    }
}
