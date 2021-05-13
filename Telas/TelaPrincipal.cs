using System;
using Clube_Leitura.Controladores;

namespace Clube_Leitura.Telas
{
    class TelaPrincipal
    {
        private ControladorCaixas controladorC = new ControladorCaixas();
        private Controlador controladorR = new Controlador();
        private Controlador controladorA = new Controlador();
        private Controlador controladorE = new Controlador();
        private Tela tela;
        public TelaPrincipal()
        {
            while (true)
            {
                tela = selecionarTela();
                if (tela == null) { Program.erro("Opcão inválida!"); continue; }
                tela.menu();
            }
        }
        public Tela selecionarTela()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Clube da Leitura");
                Console.WriteLine("\nDigite: ");
                Console.WriteLine("1- para visualizar o menu de Amiguinhos");
                Console.WriteLine("2- para visualizar o menu de Caixas");
                Console.WriteLine("3- para visualizar o menu de Revistas");
                Console.WriteLine("4- para visualizar o menu de Empréstimos");

                Console.ResetColor();

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1": tela = new TelaAmiguinhos(controladorA, controladorE); break;
                    case "2": tela = new TelaCaixas(controladorC, controladorR); break;
                    case "3": tela = new TelaRevistas(controladorR, controladorC, controladorE); break;
                    case "4": tela = new TelaEmprestimos(controladorE, controladorA, controladorR); break;

                    default: tela = null; break;
                }
                return tela;
            }
        }
    }
}