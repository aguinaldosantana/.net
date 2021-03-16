using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculo
    {
        public int _resultado;

        private void adicao(int n1, int n2)
        {
            this._resultado = n1 + n2;
        }

        public void subtracao(int n1, int n2)
        {
            this._resultado = n1 - n2;
        }

        public void multiplicacao(int n1, int n2)
        {
        
            if (n1 == 0 || n2 == 0)

            {
                Console.WriteLine("Qualquer numero multiplicado por 0 e' 0!");
            }
            else 
            {
                this._resultado = n1 * n2;
            }
            
            
        }

        public void divisao(int n1, int n2)
        {
            this._resultado = n1 / n2;
        }

        public void Modulo(int n1, int n2)
        {
            this._resultado = n1 % n2;
        }

    }
}
