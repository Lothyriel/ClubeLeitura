using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using System;
using System.Collections.Generic;

namespace Clube_Leitura.Validadores
{
    class ValidadorEmprestimo : Validador
    {
        private Controlador controladorA;
        private Controlador controladorR;
        public ValidadorEmprestimo(Controlador controlador, Controlador controladorA, Controlador controladorR) : base(controlador)
        {
            this.controladorA = controladorA;
            this.controladorR = controladorR;
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
                Program.printList(amiguinhosSemEmprestimo());
                string amiguinhoStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(amiguinhoStr, out iAmiguinho) && iAmiguinho <= amiguinhosSemEmprestimo().Count && iAmiguinho > 0) { break; }
            }
            amiguinho = amiguinhosSemEmprestimo()[iAmiguinho - 1];
            while (true)
            {
                Console.WriteLine("Digite o número da revista desejada");
                Program.printList(revistasDisponiveis()); ;
                string revistaStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(revistaStr, out iRevista) && iRevista <= controladorR.Registros.Count && iRevista > 0) { break; }
            }
            revista = revistasDisponiveis()[iRevista - 1];
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

        public List<Amiguinho> amiguinhosSemEmprestimo()
        {
            List<Amiguinho> amiguinhos = new List<Amiguinho>();
            foreach (Amiguinho a in controladorA.Registros)
            {
                bool esta = false;
                foreach (Emprestimo e in controlador.Registros)
                {
                    if (e.Amiguinho == a) { esta = true; }
                }
                if (!esta) { amiguinhos.Add(a); }
            }
            return amiguinhos;
        }

        public List<Revista> revistasDisponiveis()
        {
            List<Revista> revistas = new List<Revista>();
            foreach (Revista r in controladorR.Registros)
            {
                bool esta = false;
                foreach (Emprestimo e in controlador.Registros)
                {
                    if (e.Revista == r) { esta = true; }
                }
                if (!esta) { revistas.Add(r); }
            }
            return revistas;
        }
    }
}
