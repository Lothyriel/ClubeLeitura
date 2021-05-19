using Clube_Leitura.Controladores;
using System;

namespace Clube_Leitura.Validadores
{
    abstract class Validador
    {
        protected Controlador controlador;
        public Validador(Controlador controlador)
        {
            this.controlador = controlador;
        }
        public abstract Object objetoValido();
        public bool itemDuplicado(Object ob)
        {
            foreach (Object o in controlador.Registros)
            {
                if (ob.Equals(o)) { return true; }
            }
            return false;
        }
    }
}
