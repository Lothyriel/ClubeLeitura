using Clube_Leitura.Controladores;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaEmprestimos : Tela
    {
        private Controlador controladorA;
        private Controlador controladorR;

        public TelaEmprestimos(Controlador controladora, Controlador controladorA, Controlador controladorR) : 
        base(controladora, new ValidadorEmprestimo(controladora, controladorA, controladorR), "Tela Empréstimos")
        {
            this.controladorA = controladorA;
            this.controladorR = controladorR;
        }

        public override void cadastrar(int indice)
        {
            if (controladorA.Registros.Length == 0) { Program.erro("Nenhum amiguinho registrado!"); }
            else if (controladorR.Registros.Length == 0) { Program.erro("Nenhuma revista registrada!"); }
            else { base.cadastrar(indice); }
        }
    }
}