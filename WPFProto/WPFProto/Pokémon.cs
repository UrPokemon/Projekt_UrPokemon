using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProto
{
    public class Pokémon
    {
        ITFAttacken attacke;

        public ITFAttacken Attacke
        {
            get { return attacke; }
            set { attacke = value; }
        }

        public Pokémon() : this(null) { }                                                                   //null-Konstruktor

        public Pokémon(ITFAttacken a)                                                                       //Konstruktor
        {
            this.attacke = a;
        }



       /* public double angriff(double staerke = 0, string name = "", double accuracy = 0)                      //Angriff mit den benötigten Werten (Stärke und Name der Attacke)
        {
            schaden = attacke.angriff(staerke, name, accuracy);
            return schaden;
        }

        public void pokeName(string pokeName = "")                      //Pokémonname (kommt noch)
        {

        }
        */
    }
}
