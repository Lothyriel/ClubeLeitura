using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaRevistas : Tela
    {
        private Controlador controladorC;
        private Controlador controladorE;
        public TelaRevistas(Controlador controlador, Controlador controladorC, Controlador controladorE) :
        base(controlador, new ValidadorRevista(controlador, controladorC, controladorE), "Tela Caixas")
        {
            this.controladorE = controladorE;
            this.controladorC = controladorC;
        }
        public override void cadastrar(int indice)
        {
            if (controladorC.Registros.Length == 0) { Program.erro("Nenhuma caixa registrada!"); }
            else { base.cadastrar(indice); }
        }
        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(ref opcao);
            if (indiceValido && ((ValidadorRevista)validador).revistaEmprestada((Revista)controller.Registros[opcao - 1]))
            {
                Program.erro("Esta revista está emprestada");
            }
            else if (indiceValido) { controller.excluir(opcao); }
        }
    }
}