using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFibonacci
{
    public class Fibonacci
    {
        static public int _contadorIterativo = 0;
        static public int _contadorRecursivo = 0;

        public static int ContadorIterativo
        {
            get { return _contadorIterativo; }
        }

        public static int ContadorRecursivo
        {
            get { return _contadorRecursivo; }
        }

        public static int Iterativo(int num)
        {
           int anterior = -1, result = 1;
           for (int i = 0; i <= num; i++)
           {
                _contadorIterativo++;
               int soma = result + anterior;
               anterior = result;
               result = soma;
           }
           return result;
        }

        public static int Recursivo(int num)
        {
            _contadorRecursivo++;
            if (num <= 2)
                return 1;
            else
                return Recursivo(num - 1) + Recursivo(num - 2);
        }
    }
}
