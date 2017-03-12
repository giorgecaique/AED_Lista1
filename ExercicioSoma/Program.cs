using AED1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma = new Soma();
            DateTime inicio = DateTime.Now;
            long resultIterativo = soma.Iterativo();
            DateTime fim = DateTime.Now;
            TimeSpan difIterativo = fim - inicio;

            DateTime inicioRecursivo = DateTime.Now;
            long resultRecursivo = soma.Recursivo(0);
            DateTime fimRecursivo = DateTime.Now;
            TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

            Cabecalho.Print("Soma", difIterativo, difRecursivo, Soma.ContadorIterativo, Soma.ContadorRecursivo, resultIterativo, resultRecursivo);
        }
    }
}
