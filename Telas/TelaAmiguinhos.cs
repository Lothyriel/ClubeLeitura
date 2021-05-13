using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaAmiguinhos : Tela
    {
        public TelaAmiguinhos(Controlador controlador, Controlador controladorE) :
        base(controlador, new ValidadorAmiguinho(controlador, controladorE), "Tela Amiguinhos")
        {
        }

        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(controlador.Registros, ref opcao);
            if (indiceValido && ((ValidadorAmiguinho)validador).amiguinhoDevedor((Amiguinho)controlador.Registros[opcao - 1]))
            {
                Program.erro("Este amiguinho está vinculado a um empréstimo");
            }
            else if (indiceValido) { controlador.excluir(opcao); }
        }
    }
}
