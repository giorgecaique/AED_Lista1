using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRemoveVogal
{
    public class RemoveVogal
    {
        #region Atributos

        static char[] _vogais = { 'A', 'E', 'I', 'O', 'U' };
        static string _entrada = string.Empty;
        static public int _contadorIterativo = 0;
        static public int _contadorRecursivo = 0;

        #endregion

        #region Propriedades

        public static int ContadorIterativo
        {
            get { return _contadorIterativo; }
        }

        public static int ContadorRecursivo
        {
            get { return _contadorRecursivo; }
        }

        #endregion

        #region Métodos

        public static string Iterativo(string entrada)
        {
            entrada = entrada.ToUpper();
            string saida = string.Empty;
            for (int i = 0; i < entrada.Length; i++)
            {
                if (!_vogais.Contains(entrada[i]))
                {
                    saida += entrada[i];
                    _contadorIterativo++;
                }
            }
            return saida;
        }

        public static string Recursivo(string entrada)
        {
            _entrada = entrada.ToUpper();
            return Recursivo(0);
        }
        public static string Recursivo(int index)
        {
            if (index == _entrada.Length - 1)
            {
                _contadorRecursivo++;
                if (!_vogais.Contains(_entrada[index]))
                {
                    return _entrada[index].ToString();
                }

                return string.Empty;
            }
            else
            {
                _contadorRecursivo++;
                if (!_vogais.Contains(_entrada[index]))
                    return _entrada[index].ToString() + Recursivo(index + 1);

                return string.Empty + Recursivo(index + 1);
            }
        }

        #endregion
    }
}
