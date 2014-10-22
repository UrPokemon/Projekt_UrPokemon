using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrPokémonProto
{
    interface ITFAttaken
    {
        void angriff(double stärke)
        {
            if(PokémonA.zug==true)
            {
                PokémonB.istLeben=PokémonB.istLeben-stärke;
                PokémonA.zug=false;
                PokémonB.zug=true;
            }
            else if (PokémonB.zug == true)
            {
                PokémonA.istLeben = PokémonA.istLeben - stärke;
                PokémonB.zug = false;
                PokémonA.zug = true;
            }

        }
    }
}
