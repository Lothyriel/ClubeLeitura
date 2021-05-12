using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaAmiguinhos : Tela
    {
        public TelaAmiguinhos(Controlador controller, Controlador controllerE) :
        base(controller, new ValidadorAmiguinho(controller, controllerE), "Tela Amiguinhos")
        {
        }

        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(ref opcao);
            if (indiceValido && ((ValidadorAmiguinho)validador).amiguinhoDevedor((Amiguinho)controller.Registros[opcao - 1]))
            {
                Program.erro("Este amiguinho está vinculado a um empréstimo");
            }
            else if (indiceValido) { controller.excluir(opcao); }
        }
    }
}
