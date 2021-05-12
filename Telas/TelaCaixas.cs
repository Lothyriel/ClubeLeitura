using Clube_Leitura.Controladores;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaCaixas : Tela
    {
        private Controlador controladorR;

        public TelaCaixas(ControladorCaixas controlador, Controlador controladorR) :
        base(controlador, new ValidadorCaixa(controlador, controladorR), "Tela Caixas")
        {
            this.controladorR = controladorR;
        }
    }
}