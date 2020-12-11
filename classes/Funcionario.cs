using System;

namespace Polimorfismo_Sobrecarga.classes
{
    public class Funcionario
    {
        //Atributos
        public string[] lista = {"Paulo", "Tsuka", "Rafael", "Joao"};

        //Metodos
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }


        public void Mostrar(int indice){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(lista [indice]);
            Console.ResetColor();
        }


        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if(item == busca){
                    Console.WriteLine("Resultado da busca: " + item);
                }
                Console.ResetColor();
            }
        }


    }//Funcionario
}