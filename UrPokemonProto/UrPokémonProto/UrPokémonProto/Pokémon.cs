using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrPokémonProto
{
    class Pokémon
    {
        ITFAttaken attacke;

        public ITFAttaken Attacke
        {
            get { return attacke; }
            set { attacke = value; }
        }

        public Pokémon(ITFAttaken a)
        {
            this.attacke = a;
        }

        public void angriff()
        {
            attacke.angriff();
        }
    }
}
