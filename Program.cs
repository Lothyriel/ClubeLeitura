using Clube_Leitura.Telas;
using System;

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
        public static bool printArray(Object[] array)
        {
            if (array.Length == 0)
            {
                erro("Nada cadastrado aqui!");
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + array[i]);
                }
                return true;
            }
        }
    }
}
