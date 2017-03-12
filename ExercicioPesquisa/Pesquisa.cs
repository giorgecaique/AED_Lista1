using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AED1;

namespace ExercicioPesquisa
{
    class Pesquisa
    {
        #region Atributos

        static List<int> _list = new List<int>();
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

        #region Construtor

        public Pesquisa()
        {
            _list = AedList.Get();
        }

        #endregion

        #region Métodos

        public int Sequencial(int num)
        {
            foreach(int item in _list)
            {
                _contadorIterativo++;
                if (num == item)
                {
                    return item;
                }
            }
            return 0;
        }

        public int Binaria(int num)
        {
            return Binaria(num, 0, _list.Count - 1);
        }

        public int Binaria(int num, int inicio, int fim)
        {
            _contadorRecursivo++;

            int meio = (inicio + fim) / 2;
            if (inicio > fim)
                return 0;
            if (_list[meio] == num)
                return _list[meio];
            else if (num > _list[meio])
                return Binaria(num, meio + 1, fim);
            else
                return Binaria(num, inicio, meio - 1);
        }

        #endregion
    }
}
