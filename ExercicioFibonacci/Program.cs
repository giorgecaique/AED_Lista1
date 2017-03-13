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
            Console.Write("Digite o valor de N: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                DateTime inicio = DateTime.Now;
                long resultIterativo = Fibonacci.Iterativo(n);
                DateTime fim = DateTime.Now;
                TimeSpan difIterativo = fim - inicio;

                DateTime inicioRecursivo = DateTime.Now;
                long resultRecursivo = Fibonacci.Recursivo(n);
                DateTime fimRecursivo = DateTime.Now;
                TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

                Cabecalho.Print("Fibonacci", difIterativo, difRecursivo, Fibonacci.ContadorIterativo, Fibonacci.ContadorRecursivo, resultIterativo, resultRecursivo);
            }
            else
            {
                Console.WriteLine("Entrada inválida!");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}
