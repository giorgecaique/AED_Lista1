using AED1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSoma
{
    public class Soma
    {
        #region Atributos

        static long _soma = 0;
        static List<int> _list = new List<int>();
        private static int _contadorIterativo = 0;
        private static int _contadorRecursivo = 0;

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

        #region Construtor
        
        public Soma()
        {
            _list = AedList.Get();
        }

        #endregion  

        #region Métodos

        public long Iterativo()
        {
            foreach (int item in _list)
            {
                _soma += item;
                _contadorIterativo++;
            }
            return _soma;
        }

        public long Recursivo(int pos)
        {
            _contadorRecursivo++;
            if (pos == _list.Count - 1)
                return _list[pos - 1];

            return _soma += _list[pos] + Recursivo(pos + 1);
        }

        #endregion
    }
}
