using Clube_Leitura.Controladores;
using Clube_Leitura.Validadores;
using System;
using System.Collections.Generic;

namespace Clube_Leitura.Telas
{
    abstract class Tela
    {
        protected Controlador controlador;
        protected Validador validador;
        protected String título;

        public Tela(Controlador controller, Validador validador, String título)
        {
            controlador = controller;
            this.validador = validador;
            this.título = título;
        }

        public virtual void menu()
        {
            Console.WriteLine(título + "\n");
            Console.WriteLine("1- para visualizar registros");
            Console.WriteLine("2- para cadastrar novos registros");
            Console.WriteLine("3- para editar registros");
            Console.WriteLine("4- para excluir registros\n");
            Console.WriteLine("0- para voltar");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": Program.printList(controlador.Registros); break;
                case "2": cadastrar(-1); break;
                case "3": edit(); break;
                case "4": excluir(); break;
                case "0": break;

                default: Program.erro("Comando incorreto!"); break;
            }
        }
        protected bool getIndiceLista(List<Object> lista, ref int opcaoInt)
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para editar ou digite 0 para cancelar");
                if (!Program.printList(lista)) { return false; }
                string opcao = Console.ReadLine();
                if (opcao == "0") { return false; }

                if (!int.TryParse(opcao, out opcaoInt) || opcaoInt < 0 || opcaoInt > controlador.Registros.Count) { continue; }

                return true;
            }
        }
        public virtual void cadastrar(int indice)
        {
            Object obj = validador.objetoValido();

            if (validador.itemDuplicado(obj) && indice == -1) { Program.erro("Item já esta cadastrado"); }

            else
            {
                controlador.cadastrar(indice, obj);
            }
        }
        public virtual void excluir()
        {
            int opcaoInt = 0;
            if (getIndiceLista(controlador.Registros, ref opcaoInt))
            {
                controlador.excluir(opcaoInt);
            }
        }
        public void edit()
        {
            int opcaoInt = 0;
            if (getIndiceLista(controlador.Registros, ref opcaoInt))
            {
                cadastrar(opcaoInt);
            }
        }
    }
}
