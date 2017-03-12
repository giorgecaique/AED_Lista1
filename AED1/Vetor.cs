using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AED1
{
    class Vetor
    {
        public static List<int> Get()
        {
            List<int> list = new List<int>();
            StreamReader reader = new StreamReader("vetorCompleto.txt");
            while (!reader.EndOfStream)
            {
                list.Add(int.Parse(reader.ReadLine()));
            }
            return list;
        }
    }
}
