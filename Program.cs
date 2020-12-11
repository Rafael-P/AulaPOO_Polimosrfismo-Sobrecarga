using System;
using Polimorfismo_Sobrecarga.classes;

namespace Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Instacia da classe Funcionario
            Funcionario fun = new Funcionario();

            fun.Mostrar();

            fun.Mostrar(1);

            fun.Mostrar("Rafael");

        }//main
    }
}
