using System;

namespace Clube_Leitura.Controladores
{
    class Controlador
    {
        protected Object[] registros = new Object[0];

        public virtual Object[] Registros { get => registros; }

        public virtual void cadastrar(int indice, Object obj)
        {
            if (indice == -1)
            {
                Array.Resize(ref registros, registros.Length + 1);
                registros[registros.Length - 1] = obj;
            }
            else { registros[indice - 1] = obj; }
        }

        public virtual void excluir(int indice)
        {
            for (int i = indice; i < Registros.Length; i++)
            {
                Object obj = registros[i];
                registros[i - 1] = obj;
            }
            Array.Resize(ref registros, registros.Length - 1);
        }
    }
}
