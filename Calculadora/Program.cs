using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var testeCalculadora = new Calculo();
         
            Console.WriteLine($"Total Adicao: {testeCalculadora.Adicao(20, 2)}");
            Console.WriteLine($"Total Subtracao: {testeCalculadora.Subtracao(20, 2)}");
            Console.WriteLine($"Total Multiplicacao: {testeCalculadora.Multiplicacao(20, 3)}");
            Console.WriteLine($"Total Divisao: {testeCalculadora.Divisao(20, 2)}");
        }
    }
}
