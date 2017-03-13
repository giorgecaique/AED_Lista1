using AED1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPesquisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesquisa pesquisa = new Pesquisa();
            Console.Write("Digite o valor de N: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                DateTime inicio = DateTime.Now;
                long resultIterativo = pesquisa.Sequencial(n);
                DateTime fim = DateTime.Now;
                TimeSpan difIterativo = fim - inicio;

                DateTime inicioRecursivo = DateTime.Now;
                long resultRecursivo = pesquisa.Binaria(n);
                DateTime fimRecursivo = DateTime.Now;
                TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

                Cabecalho.Print("Pesquisa", difIterativo, difRecursivo, Pesquisa.ContadorIterativo, Pesquisa.ContadorRecursivo, resultIterativo, resultRecursivo);
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
