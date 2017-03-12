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
            DateTime inicio = DateTime.Now;
            long resultIterativo = Fatorial.Iterativo(5);
            DateTime fim = DateTime.Now;
            TimeSpan difIterativo = fim - inicio;

            DateTime inicioRecursivo = DateTime.Now;
            long resultRecursivo = Fatorial.Recursivo(5);
            DateTime fimRecursivo = DateTime.Now;
            TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

            Cabecalho.Print("Fatorial", difIterativo, difRecursivo, Fatorial.ContadorIterativo, Fatorial.ContadorRecursivo, resultIterativo, resultRecursivo);
        }
    }
}
