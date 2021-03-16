using System;
using System.Diagnostics;
using System.Threading;

namespace Ex_Cronometro
{

    class Program
    {
        static void Main(string[] args)
        {
            Cronometro c = new Cronometro();
            c.Inicio();
            throw new InvalidOperationException("Invalido");
        }
    }
}

class Cronometro
{
    public Stopwatch e = new Stopwatch();
    public void Inicio()
    {
        e.Start();
        for (int i = 0; i < 100000; i++)
        {
            Console.WriteLine(e.Elapsed);
            Thread.Sleep(1000);
        }
    }
    public void Parar()
    {
        e.Stop();
        Console.WriteLine(e.Elapsed);
    }
}
