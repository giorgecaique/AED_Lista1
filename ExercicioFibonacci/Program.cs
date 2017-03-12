using AED1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now;
            long resultIterativo = Fibonacci.Iterativo(40);
            DateTime fim = DateTime.Now;
            TimeSpan difIterativo = fim - inicio;

            DateTime inicioRecursivo = DateTime.Now;
            long resultRecursivo = Fibonacci.Recursivo(40);
            DateTime fimRecursivo = DateTime.Now;
            TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

            Cabecalho.Print("Fibonacci", difIterativo, difRecursivo, Fibonacci.ContadorIterativo, Fibonacci.ContadorRecursivo, resultIterativo, resultRecursivo);
        }
    }
}
