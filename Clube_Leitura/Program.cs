using Clube_Leitura.Telas;
using System;
using System.Collections;

namespace Clube_Leitura
{
    class Program
    {
        private static void Main(string[] args)
        {
            new TelaPrincipal();
        }
        public static void erro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(mensagem); Console.ResetColor();
        }
        public static bool printList(IList lista)
        {
            if (lista.Count == 0)
            {
                erro("Nada cadastrado aqui!");
                return false;
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + lista[i]);
                }
                return true;
            }
        }
    }
}
