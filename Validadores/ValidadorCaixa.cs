using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using System;


namespace Clube_Leitura.Validadores
{
    class ValidadorCaixa : Validador
    {
        private new ControladorCaixas controlador;
        public ValidadorCaixa(ControladorCaixas controlador) : base(controlador)
        {
            this.controlador = controlador;
        }

        public override object objetoValido()
        {
            string cor, etiqueta;

            while (true)
            {
                Console.WriteLine("Digite a cor da caixa");
                cor = Console.ReadLine(); //"Preto"; // 
                if (cor.Length > 3) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o conteúdo da etiqueta");
                etiqueta = Console.ReadLine(); //"Caixa de quadrinhos"; // 
                if (etiqueta.Length > 0) { break; }
            }

            return new Caixa(cor, etiqueta, controlador.IndiceCaixa);
        }
    }
}
