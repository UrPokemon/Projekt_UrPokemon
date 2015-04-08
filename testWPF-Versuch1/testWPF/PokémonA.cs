using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWPF
{
    public class PokémonA : Pokémon                                     //PokémonA vererbte Klasse von Pokémon
    {
        public static bool zug = false;                                 //bool ob das Pokémon am Zug ist
        public static double istLeben = maxLeben;                       //momentane Leben auf Maximalleben setzen
        public const double maxLeben = 150;                             //Maximalleben festlegen

        public int staerkeF = 35;
        public string nameF = "Flammenwurf";
        public double accuF = 60;

        public int staerkeT = 15;
        public string nameT = "Tackle";
        public double accuT = 80;

        public int staerkeG = 20;
        public string nameG = "Genesung";
        public double accuG = 50;

        public void Flammenwurf()                                       //Attacke 1 des Pokémons A
        {
            Attacke = new NormalAttack();                               //neue Standardattacke (Flammenwurf)
            Attacke.angriff(staerkeF, nameF, accuF);
        }

        public void Tackle()                                            //Attacke 2 des Pokémons A
        {
            Attacke = new NormalAttack();                               //neue Standardattacke (Tackle)
            Attacke.angriff(staerkeT, nameT, accuT);
        }

        public void Genesung()                                          //Attacke 3 des Pokémons A
        {
            Attacke = new HealingEffects();                             //Neuer Heileffekt (Genesung)
            Attacke.angriff(staerkeG, nameG, accuG);
        }

    }
}
