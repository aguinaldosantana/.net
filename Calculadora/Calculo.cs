using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculo
    {
        private decimal resultado;

        public decimal Adicao(int n1, int n2)
        {
            return resultado = n1 + n2;
        }

        public decimal Subtracao(int n1, int n2)
        {
            return resultado = n1 - n2;
        }

        public decimal Multiplicacao(decimal n1, decimal n2)
        {
            if (n1 == 0 || n2 == 0)

            {
                Console.WriteLine("valores nao permitidos");
            }
                return resultado = n1 * n2;
        }

        public decimal Divisao(int n1, int n2)
        {
            return resultado = n1 / n2;
        }

        public decimal Modulo(int n1, int n2)
        {
            return resultado = n1 % n2;
        }
    }
}
