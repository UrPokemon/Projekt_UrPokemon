using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrPokémonProto
{
        class NormalAttack : ITFAttaken                                                 //Normale Attacke definieren
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
                        PokémonA.zug = false;                                           //PokémonA ist nicht mehr am Zug
                        PokémonB.zug = true;                                            //PokémonB ist nun an der Reihe
                    }
                    else if (PokémonB.zug == true)                                      //Falls PokémonB am Zug ist
                    {
                        Console.WriteLine("Setzt " + name + " ein!");
                        PokémonA.istLeben = PokémonA.istLeben - astaerke;
                        Console.WriteLine("Verursacht " + astaerke
                            + " Schaden");
                        PokémonB.zug = false;
                        PokémonA.zug = true;
                    }

                }
                else
                {
                    Console.WriteLine("Der Angriff ging ins Leere! ");
                }
            }
        }

        /*class StatusAttack : ITFAttaken                                             // Statusattacken sollen den Gegner bzw. sich selbst beeinflussen, kommt noch
        {
            static Random Rnd = new Random();
            double acc = Rnd.Next(0, 100);

            double schwank = Rnd.Next(-5, +5);
            double astaerke = 0;

            public void angriff(double stärke, string name, double accuracy, bool ally)
            {
                if ((acc <= accuracy)&&(ally == true))
                {

                }
                else if ((acc <= accuracy) && (ally == false))
                {

                }
                else
                {
                    Console.WriteLine("Der Effekt hat keine Wirkung! ");
                }

            }
        }
         * */

        class DoubleAttack : ITFAttaken                                             // Attacken die über mehrere Züge gehen, kommt noch
        {
            public void angriff(double stärke, string name, double accuracy)
            {

            }
        }
 }

