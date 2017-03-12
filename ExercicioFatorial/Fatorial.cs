using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFatorial
{
    public class Fatorial
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
            int fatorial = num;
            for (int i = num; i > 1; i--)
            {
                _contadorIterativo++;
                fatorial = fatorial * (i - 1);
            }
            return fatorial;
        }

        public static int Recursivo(int num)
        {
            _contadorRecursivo++;
            if (num == 1)
                return 1;
            else
                return num * Recursivo(num - 1);
        }
    }
}
