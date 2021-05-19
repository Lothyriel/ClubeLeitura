using Clube_Leitura.Domínio;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Clube_Leitura.Controladores
{
    class ControladorCaixas : Controlador
    {
        public int IndiceCaixa { get => corrigirIndice(); }
        private int corrigirIndice()
        {
            bool utilizado;
            int id;
            for (id = 0; id < Registros.Count; id++)
            {
                utilizado = false;
                foreach (Caixa c in Registros)
                {
                    if (id + 1 == c.Numero) { utilizado = true; } //i -1 pois os valores do array começam em 0 e os da caixa em 1
                }
                if (!utilizado) { break; }
            }
            return id + 1;
        }
    }
}