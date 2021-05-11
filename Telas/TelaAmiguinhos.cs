using Clube_Leitura.Controladores;
using Clube_Leitura.Validadores;

namespace Clube_Leitura.Telas
{
    class TelaAmiguinhos : Tela
    {
        public TelaAmiguinhos(Controlador controller, Controlador controllerE) :
        base(controller, new ValidadorAmiguinho(controller, controllerE), "Tela Amiguinhos")
        {

        }
    }
}
