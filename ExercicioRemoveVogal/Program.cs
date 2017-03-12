using AED1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRemoveVogal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um texto de entrada: \n");
            string entrada = Console.ReadLine();
            DateTime inicio = DateTime.Now;
            string resultIterativo = RemoveVogal.Iterativo(entrada);
            DateTime fim = DateTime.Now;
            TimeSpan difIterativo = fim - inicio;

            DateTime inicioRecursivo = DateTime.Now;
            string resultRecursivo = RemoveVogal.Recursivo(entrada);
            DateTime fimRecursivo = DateTime.Now;
            TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

            Cabecalho.Print("Remove Vogal", difIterativo, difRecursivo, RemoveVogal.ContadorIterativo, RemoveVogal.ContadorRecursivo, resultIterativo, resultRecursivo);
        }
    }
}
