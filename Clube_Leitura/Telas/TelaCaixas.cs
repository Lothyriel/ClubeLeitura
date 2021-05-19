using Clube_Leitura.Controladores;
using Clube_Leitura.Domínio;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaCaixas : Tela
    {
        public TelaCaixas(ControladorCaixas controlador, Controlador controladorR) :
        base(controlador, new ValidadorCaixa(controlador, controladorR), "Tela Caixas")
        {
        }
        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(controlador.Registros, ref opcao);
            if (indiceValido && ((ValidadorCaixa)validador).caixaComLivro((Caixa)controlador.Registros[opcao - 1]))
            {
                Program.erro("Esta caixa contém livros!");
            }
            else if (indiceValido) { controlador.excluir(opcao); }
        }
    }
}