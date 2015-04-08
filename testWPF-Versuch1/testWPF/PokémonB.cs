using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWPF
{
    public class PokémonB : Pokémon                                     //PokémonA vererbte Klasse von Pokémon
    {
        public static bool zug = false;                                 //bool ob das Pokémon am Zug ist
        public static double istLeben = maxLeben;                       //momentane Leben auf Maximalleben setzen
        public const double maxLeben = 180;                             //Maximalleben festlegen

        public int staerkeR = 25;
        public string nameR = "Rasierblatt";
        public double accuR = 70;

        public int staerkeT = 15;
        public string nameT = "Tackle";
        public double accuT = 80;

        public int staerkeG = 30;
        public string nameG = "Genesung";
        public double accuG = 40;

        public void Rasierblatt()                                       //Attacke 1 des Pokémons B
        {
            Attacke = new NormalAttack();                               //neue Standardattacke (Rasierblatt)
            Attacke.angriff(staerkeR, nameR, accuR);
        }

        public void Tackle()                                            //Attacke 2 des Pokémons B
        {
            Attacke = new NormalAttack();                               //neue Standardattacke (Tackle)
            Attacke.angriff(staerkeT, nameT, accuT);
        }

        public void Genesung()                                          //Attacke 3 des Pokémons B
        {
            Attacke = new HealingEffects();                             //neuer Heileffekt (Genesung)
            Attacke.angriff(staerkeG, nameG, accuG);
        }

    }
}
