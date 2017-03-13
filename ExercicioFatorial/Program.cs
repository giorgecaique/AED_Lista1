using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AED1;

namespace ExercicioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int n;
            if(int.TryParse(Console.ReadLine(), out n))
            {
                DateTime inicio = DateTime.Now;
                long resultIterativo = Fatorial.Iterativo(n);
                DateTime fim = DateTime.Now;
                TimeSpan difIterativo = fim - inicio;

                DateTime inicioRecursivo = DateTime.Now;
                long resultRecursivo = Fatorial.Recursivo(n);
                DateTime fimRecursivo = DateTime.Now;
                TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

                Cabecalho.Print("Fatorial", difIterativo, difRecursivo, Fatorial.ContadorIterativo, Fatorial.ContadorRecursivo, resultIterativo, resultRecursivo);
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
