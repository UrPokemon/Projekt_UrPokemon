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
            Random Rnd = new Random();
            int RndNr3 = Rnd.Next(0, 2);
            if (RndNr3 <= 1)
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
