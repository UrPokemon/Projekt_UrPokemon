using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrPokémonProto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random zufall = new Random();
            double z = zufall as double;
            if (zufall * 2 <= 1)
            {
                PokémonA.zug = true;
            }
            else
            {
                PokémonB.zug = true;
            }
        }
    }
}
