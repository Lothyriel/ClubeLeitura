using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using System;

namespace Clube_Leitura.Validadores
{
    class ValidadorEmprestimo : Validador
    {
        private Controlador controllerA;
        private Controlador controllerR;
        public ValidadorEmprestimo(Controlador controller, Controlador controllerA, Controlador controllerR) : base(controller)
        {
            this.controllerA = controllerA;
            this.controllerR = controllerR;
        }

        public override Object objetoValido()
        {
            Amiguinho amiguinho;
            Revista revista;
            DateTime dataEmprestimo, dataDevolucao;

            int iAmiguinho, iRevista;

            while (true)
            {
                Console.WriteLine("Digite o número do amiguinho");
                Program.printArray(controllerA.Registros);
                string amiguinhoStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(amiguinhoStr, out iAmiguinho) && iAmiguinho <= controllerA.Registros.Length && iAmiguinho > 0) { break; }
            }
            amiguinho = (Amiguinho)controllerA.Registros[iAmiguinho - 1];
            while (true)
            {
                Console.WriteLine("Digite o número da revista desejada");
                Program.printArray(controllerR.Registros);
                string revistaStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(revistaStr, out iRevista) && iRevista <= controllerR.Registros.Length && iRevista > 0) { break; }
            }
            revista = (Revista)controllerR.Registros[iRevista - 1];
            while (true)
            {
                Console.WriteLine("Digite a data de empréstimo");
                string dataEmprestimoStr = Console.ReadLine(); //"27/04/2011"; //
                if (DateTime.TryParse(dataEmprestimoStr, out dataEmprestimo) && dataEmprestimo.CompareTo(DateTime.Now) < 0) { break; };
            }
            while (true)
            {
                Console.WriteLine("Digite a data de devolução");
                string dataDevolucaoStr = Console.ReadLine(); //"27/04/2012"; //
                if (DateTime.TryParse(dataDevolucaoStr, out dataDevolucao) && dataDevolucao.CompareTo(dataEmprestimo) > 0) { break; };
            }

            return new Emprestimo(amiguinho, revista, dataEmprestimo, dataDevolucao);
        }
    }
}
