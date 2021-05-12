using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using System;

namespace Clube_Leitura.Validadores
{
    class ValidadorAmiguinho : Validador
    {
        private Controlador controladorE;
        public ValidadorAmiguinho(Controlador controlador, Controlador controladorE) : base(controlador)
        {
            this.controladorE = controladorE;
        }
        public override Object objetoValido()
        {
            string nome, nome_responsavel, telefone, bairro;

            while (true)
            {
                Console.WriteLine("Digite o nome do amiguinho");
                nome = Console.ReadLine(); //"Joãozinho"; // 
                if (nome.Length > 0) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o nome do responsável");
                nome_responsavel = Console.ReadLine(); //"Pai do Joãozinho"; // 
                if (nome_responsavel.Length > 0) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número de telefone do responsável");
                telefone = Console.ReadLine(); //"4999879114"; //
                if (long.TryParse(telefone, out _)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o bairro do amiguinho");
                bairro = Console.ReadLine(); //"Conta Dinheiro"; //
                if (bairro.Length > 0) { break; };
            }

            return new Amiguinho(nome, nome_responsavel, telefone, bairro);
        }
        public bool amiguinhoDevedor(Amiguinho a)
        {
            foreach (Emprestimo e in controladorE.Registros)
            {
                if (e.Amiguinho == a) return true;
            }
            return false;
        }
    }
}
