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

            DateTime inicio = DateTime.Now;
            long resultIterativo = pesquisa.Sequencial(9);
            DateTime fim = DateTime.Now;
            TimeSpan difIterativo = fim - inicio;

            DateTime inicioRecursivo = DateTime.Now;
            long resultRecursivo = pesquisa.Binaria(9);
            DateTime fimRecursivo = DateTime.Now;
            TimeSpan difRecursivo = fimRecursivo - inicioRecursivo;

            Cabecalho.Print("Pesquisa", difIterativo, difRecursivo, Pesquisa.ContadorIterativo, Pesquisa.ContadorRecursivo, resultIterativo, resultRecursivo);
        }
    }
}
