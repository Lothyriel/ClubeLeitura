using Clube_Leitura.Controladores;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaCaixas : Tela
    {
        public TelaCaixas(ControladorCaixas controlador) : 
        base(controlador, new ValidadorCaixa(controlador), "Tela Caixas")
        {

        }
    }
}