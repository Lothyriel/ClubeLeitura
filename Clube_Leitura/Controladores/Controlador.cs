using System;
using System.Collections.Generic;

namespace Clube_Leitura.Controladores
{
    class Controlador
    {
        protected List<Object> registros = new List<Object>();

        public virtual List<Object> Registros { get => registros; }

        public void cadastrar(int indice, Object obj)
        {
            if (indice == -1)
            {
                registros.Add(obj);
            }
            else { registros[indice - 1] = obj; }
        }

        public virtual void excluir(int indice)
        {
            registros.RemoveAt(indice - 1);
        }
    }
}