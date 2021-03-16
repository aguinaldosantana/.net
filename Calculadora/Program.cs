using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var soma = new Calculo();
            soma.multiplicacao(10, 2);
            Console.WriteLine("Total: {0}", soma._resultado);
        }
    }
}
