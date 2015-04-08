using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWPF
{
    public class NormalAttack : ITFAttaken                                                 //Normale Attacke definieren
    {
        static Random Rnd = new Random();
        double acc = Rnd.Next(0, 100);                                              //Randomzahl für Genauhigkeit der Attacke festlegen

        double schwank = Rnd.Next(-5, +5);                                          //Schwankung der Angriffsstärke der Attacke
        double astaerke = 0;

        public void angriff(double stärke, string name, double accuracy)            //Eigenschaften festlegen
        {
            if (acc <= accuracy)
            {
                astaerke = stärke + schwank;

                if (PokémonA.zug == true)                                           //Falls PokémonA am Zug ist soll der Damage-Step ausgeführt werden
                {
                    Console.WriteLine("Setzt " + name + " ein!");                   //Message, dass die Attacke ausgeführt wird
                    PokémonB.istLeben = PokémonB.istLeben - astaerke;                 //Schaden vom Leben des betroffenen Pokémons abziehen
                    Console.WriteLine("Verursacht " + astaerke + " Schaden");         //Schaden anzeigen

                }
                else if (PokémonB.zug == true)                                      //Falls PokémonB am Zug ist
                {
                    Console.WriteLine("Setzt " + name + " ein!");
                    PokémonA.istLeben = PokémonA.istLeben - astaerke;
                    Console.WriteLine("Verursacht " + astaerke
                        + " Schaden");
                }

            }
            else
            {
                Console.WriteLine("Der Angriff ging ins Leere! ");
            }
        }
    }

    class HealingEffects : ITFAttaken                                             //Attacken die einen heilenden Effekt haben
    {
        static Random Rnd = new Random();
        double acc = Rnd.Next(0, 100);

        double schwank = Rnd.Next(-10, +10);
        double statusdiff = 0;

        public void angriff(double stärke, string name, double accuracy)
        {
            if (acc <= accuracy)
            {
                statusdiff = stärke + schwank;                                      //Berechnen der Heilstärke

                if (PokémonA.zug == true)
                {
                    Console.WriteLine("Setzt " + name + " ein!");

                    if (PokémonA.istLeben + statusdiff < PokémonA.maxLeben)         //Falls das Leben + der Heileffekt nicht über das Maximalleben geht,
                    {                                                               //sollen die HP um den Heileffekt erhöht werden
                        PokémonA.istLeben = PokémonA.istLeben + statusdiff;
                    }
                    else                                                            //Falls die HP über den Maximalwert gehen würden -> auf Maximalwert setzen
                    {
                        PokémonA.istLeben = PokémonA.maxLeben;
                    }

                    Console.WriteLine("Heilt um " + statusdiff + " HP");
                }
                else if (PokémonB.zug == true)
                {
                    Console.WriteLine("Setzt " + name + " ein!");

                    if (PokémonB.istLeben + statusdiff < PokémonB.maxLeben)
                    {
                        PokémonB.istLeben = PokémonB.istLeben + statusdiff;
                    }
                    else
                    {
                        PokémonB.istLeben = PokémonB.maxLeben;
                    }

                    Console.WriteLine("Heilt um " + statusdiff + " HP");
                }
            }
            else
            {
                Console.WriteLine("Der Effekt hat keine Wirkung! ");
            }

        }
    }

    class StatusAttack : ITFAttaken                                                 // Statusattacken sollen den Gegner bzw. sich selbst beeinflussen, kommt noch
    {
        public void angriff(double stärke, string name, double accuracy)
        {

        }
    }


    class DoubleAttack : ITFAttaken                                                 // Attacken die über mehrere Züge gehen, kommt noch
    {
        public void angriff(double stärke, string name, double accuracy)
        {

        }
    }
}
