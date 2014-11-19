using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWPF
{
        public class Pokémon
        {
            public ITFAttaken attacke;

            public ITFAttaken Attacke
            {
                get { return attacke; }
                set { attacke = value; }
            }

            public Pokémon() : this(null) { }                                                                   //null-Konstruktor

            public Pokémon(ITFAttaken a)                                                                        //Konstruktor
            {
                this.attacke = a;
            }



            public void angriff(double staerke = 0, string name = "", double accuracy = 0)                      //Angriff mit den benötigten Werten (Stärke und Name der Attacke)
            {
                attacke.angriff(staerke, name, accuracy);
            }

            public void pokeName(string pokeName = "")                                                          //Pokémonname (kommt noch)
            {

            }

        }
}
