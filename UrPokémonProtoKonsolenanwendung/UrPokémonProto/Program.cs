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
            PokémonA Glurak = new PokémonA();                                       //Objekt Glurak    aus PokémonA erzeugen
            PokémonB Bisafloor = new PokémonB();                                    //Objekt Bisafloor aus PokémonB erzeugen
            
           /* Attacke1 Tackle      = new Attacke1();
            Attacke2 Flammenwurf = new Attacke2();
            Attacke3 Rasierblatt = new Attacke3();*/

            Glurak.pokeName("Glurak");                                              //Name des Objekts Glurak    festlegen
            Bisafloor.pokeName("Bisafloor");                                        //Name des Objekts Bisafloor festlegen

            Random Rnd = new Random();                                              //Zufallwert erzeugen
            int RndNr3 = Rnd.Next(0, 2);                                            //Variable zwischen 0 und 2 erzeugen (int rundet z.B. 1.99 auf 1 ab)

            string spieler1 ="";                                                    //Spielername des Spielers 1 deklarieren
            string spieler2 = "";                                                   //Spielername des Spielers 2 deklarieren

            Console.WriteLine("Bitte Spielername (P1) eingeben! ");                 //Message für die Spielereingabe Spieler 1
            spieler1 = Console.ReadLine();                                          //Namenseingabe
            Console.WriteLine();

            Console.WriteLine("Bitte Spielername (P2) eingeben! ");                 // =//=
            spieler2 = Console.ReadLine();                                          // =//=
            Console.WriteLine();


            if (RndNr3 < 1)                                                         //Falls der Zufallswert zwischen 0 und 1 liegt
            {
                PokémonA.zug = true;                                                //Pokémon A ist am Zug
                Console.WriteLine(spieler1 + " beginnt! \n");                       //Notiz, dass Spieler 1 anfängt
            }
            else
            {
                PokémonB.zug = true;                                                // =//=
                Console.WriteLine(spieler2 + " beginnt! \n");                       // =//=
            }



            while ((PokémonA.istLeben > 0) && (PokémonB.istLeben > 0))                  //Solang kein Pokémon ausscheidet, soll der Kampf weitergehen
            {
                if (PokémonA.zug == true)                                           //Falls Pokémon A am Zug
                {
                    Console.WriteLine("Glurak HP: " +PokémonA.istLeben + "/" +      //Ausgabe der Spielerwerte
                    PokémonA.maxLeben + " // " + "Bisafloor HP: " + 
                    PokémonB.istLeben + "/" + PokémonB.maxLeben); 

                    char wahl;                                                      //Deklarierung eines Hilfschars der Eingabe
                    Console.WriteLine("Bitte eine Attacke auswaehlen: a = Tackle, b = Flammenwurf ");
                    wahl = Convert.ToChar(Console.ReadLine());                      //Eingabe einlesen
                    switch (wahl)                                                   //Auswahl, was bei Tastendruck passieren soll
                    {
                        case 'a': Glurak.Tackle();                                  //Falls 'a' gedrückt wird, soll die Attacke Tackle ausgeführt werden
                                  PokémonA.zug = false;
                                  PokémonB.zug = true;
                            break;
                        case 'b': Glurak.Flammenwurf();                             //Falls 'b' gedrückt wird, soll die Attacke Flammenwurf ausgeführt werden
                                  PokémonA.zug = false;
                                  PokémonB.zug = true;
                            break;
                        default: Console.WriteLine("Invalide Ausgabe");             //Falls eine falsche Taste gedrückt wird
                            break;
                    }

                    Console.WriteLine();

                }
                else  if (PokémonB.zug == true)                                     // =//=...
                {
                    Console.WriteLine("Bisafloor HP: " + PokémonB.istLeben + "/" + 
                    PokémonB.maxLeben + " // " + "Glurak HP: " + 
                    PokémonA.istLeben + "/" + PokémonA.maxLeben); 

                    char wahl;
                    Console.WriteLine("Bitte eine Attacke auswaehlen: a = Tackle, b = Rasierblatt ");
                    wahl = Convert.ToChar(Console.ReadLine());
                    switch (wahl)
                    {
                        case 'a': Bisafloor.Tackle(); 
                                  PokémonB.zug = false;
                                  PokémonA.zug = true;
                            break;
                        case 'b': Bisafloor.Rasierblatt();
                                  PokémonB.zug = false;
                                  PokémonA.zug = true;
                            break;
                        default: Console.WriteLine("Invalide Eingabe"); 
                            break;
                    }
                    
                    Console.WriteLine();

                }


            }
            
            if (PokémonA.istLeben <= 0)                                             //Pokémon A wird kampfunfähig = Spieler 1 verliert
            {
                Console.WriteLine();
                Console.WriteLine(spieler1 + "'s Pokémon kann nicht mehr weiterkämpfen, " + spieler2 + " gewinnt!");
                Console.ReadKey();
            }

            if (PokémonB.istLeben <= 0)                                             //Pokémon B wird kampfunfähog = Spieler 2 verliert
            {
                Console.WriteLine();
                Console.WriteLine(spieler2 + "'s Pokémon kann nicht mehr weiterkämpfen, " + spieler1 + " gewinnt!");
                Console.ReadKey();
            }

        }
    }
}
