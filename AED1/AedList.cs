using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AED1
{
    public class AedList
    {
        static List<int> _list = new List<int>();

        static private void Populate()
        {
            StreamReader reader = new StreamReader("vetorCompleto.txt");
            while (!reader.EndOfStream)
            {
                _list.Add(int.Parse(reader.ReadLine()));
            }
            reader.Close();
        }

        static public List<int> Get()
        {
            try
            {
                Populate();
                return _list;
            }
            catch { return null; }
        }
    }
}
