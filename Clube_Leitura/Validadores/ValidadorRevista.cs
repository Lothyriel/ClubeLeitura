using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using System;

namespace Clube_Leitura.Validadores
{
    class ValidadorRevista : Validador
    {
        private Controlador controladorC;
        private Controlador controladorE;
        public ValidadorRevista(Controlador controlador, Controlador controladorC, Controlador controladorE) : base(controlador)
        {
            this.controladorC = controladorC;
            this.controladorE = controladorE;
        }
        public override object objetoValido()
        {
            string colecao;
            int nro_edicao, ano, iCaixa;
            Caixa caixa;

            while (true)
            {
                Console.WriteLine("Digite o nome da coleção");
                colecao = Console.ReadLine(); //"Batman"; // 
                if (colecao.Length > 0) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número da edição");
                string nroStr = Console.ReadLine(); //"50"; // 
                if (int.TryParse(nroStr, out nro_edicao)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o ano da edição");
                string anoStr = Console.ReadLine(); //"2014"; //
                if (int.TryParse(anoStr, out ano)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número da caixa para armazenar");
                Program.printList(controladorC.Registros);
                string caixaStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(caixaStr, out iCaixa) && iCaixa <= controladorC.Registros.Count && iCaixa > 0) { break; }
            }
            caixa = (Caixa)controladorC.Registros[iCaixa - 1];

            return new Revista(colecao, nro_edicao, ano, caixa);
        }

        public bool revistaEmprestada(Revista r)
        {
            foreach (Emprestimo e in controladorE.Registros)
            {
                if (e.Revista == r) return true;
            }
            return false;
        }
    }
}