using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using Clube_Leitura.Validadores;
using System;
using System.Linq;

namespace Clube_Leitura.Telas
{
    class TelaEmprestimos : Tela
    {
        private Controlador controladorA;
        private ValidadorAmiguinho validadorA;

        public TelaEmprestimos(Controlador controlador, Controlador controladorA, Controlador controladorR) :
        base(controlador, new ValidadorEmprestimo(controlador, controladorA, controladorR), "Tela Empréstimos")
        {
            this.controladorA = controladorA;
            validadorA = new ValidadorAmiguinho(controladorA, controlador);
        }

        public override void cadastrar(int indice)
        {
            if (((ValidadorEmprestimo)validador).amiguinhosSemEmprestimo().Length == 0) { Program.erro("Nenhum amiguinho disponível!"); }
            else if (((ValidadorEmprestimo)validador).revistasDisponiveis().Length == 0) { Program.erro("Nenhuma revista disponível!"); }
            else { base.cadastrar(indice); }
        }
        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(controlador.Registros, ref opcao);
            if (indiceValido && !validadorA.amiguinhoDevedor((Amiguinho)controladorA.Registros[opcao - 1]))
            {
                Program.erro("Este amiguinho não tem um empréstimo atual");
            }
            else if (indiceValido) { controlador.excluir(opcao); }
        }
        public override void menu()
        {
            Console.WriteLine(título + "\n");
            Console.WriteLine("1- para visualizar empréstimos de hoje");
            Console.WriteLine("2- para visualizar empréstimos de um determinado mês");
            Console.WriteLine("3- para fazer novos empréstimos");
            Console.WriteLine("4- para fazer devoluções");
            Console.WriteLine("0- para voltar");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": visualizarMes(DateTime.Today); break;
                case "2": selecionarData(); break;
                case "3": cadastrar(-1); break;
                case "4": excluir(); break;
                //case "5": edit(); break;
                case "0": break;

                default: Program.erro("Comando incorreto!"); break;
            }
        }
        private void selecionarData()
        {
            DateTime dataConsulta;
            while (true)
            {
                Console.WriteLine("Digite a data para consultar os empréstimos");
                string dataConsultaStr = Console.ReadLine(); //"27/04/2011"; //
                if (DateTime.TryParse(dataConsultaStr, out dataConsulta) && dataConsulta.CompareTo(DateTime.Now) < 0) { break; };
            }
            visualizarMes(dataConsulta);
        }
        private void visualizarMes(DateTime data)
        {
            Emprestimo[] emprestimos = new Emprestimo[0];
            foreach (Emprestimo e in controlador.Registros)
            {
                if (e.DataEmprestimo.Year == data.Year && e.DataEmprestimo.Month == data.Month)
                {
                    Array.Resize(ref emprestimos, emprestimos.Length + 1); emprestimos[emprestimos.Length - 1] = e;
                }
            }
            Program.printArray(emprestimos);
        }
    }
}