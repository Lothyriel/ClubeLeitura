using System;

namespace Clube_Leitura.Domínio
{
    class Emprestimo
    {
        private Amiguinho amiguinho;
        private Revista revista;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;

        public Emprestimo(Amiguinho amiguinho, Revista revista, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            this.amiguinho = amiguinho;
            this.revista = revista;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }

        internal Revista Revista { get => revista; }
        internal Amiguinho Amiguinho { get => amiguinho; }

        public override string ToString()
        {
            return "Amiguinho: " + amiguinho.Nome + "\n/ Revista: " + revista + "\n/ Data de Empréstimo: " + dataEmprestimo + "\n/ Data de Devolução: " + dataDevolucao + " ]";
        }
    }
}
