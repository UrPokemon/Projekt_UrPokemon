using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProto
{
    public class PokémonA : Pokémon 
    {
        public double istLeben = maxLeben;
        public static double maxLeben = 150;
        public double maxLebenwert = maxLeben;

        public int staerkeF = 35;
        public string nameF = "Flammenwurf";
        public double accuF = 60;

        public int staerkeT = 15;
        public string nameT = "Tackle";
        public double accuT = 80;

        public int staerkeG = 20;
        public string nameG = "Genesung";
        public double accuG = 50;

        public double Flammenwurf()
        {
            Attacke = new NormalAttack();

            double schaden = 0;
            schaden= Attacke.angriff(staerkeF, nameF, accuF);
            if ((istLeben - schaden) > 0)
            {
                istLeben = istLeben - schaden;
                return schaden;
            }
            else if ((istLeben - schaden) <= 0)
            {
                istLeben = 0;
                return schaden;
            }
            else
            { return 0; }
        }

        public double Tackle()
        {
            Attacke = new NormalAttack();
            double schaden = 0;
            schaden = Attacke.angriff(staerkeT, nameT, accuT);
            if ((istLeben - schaden) > 0)
            {
                istLeben = istLeben - schaden;
                return schaden;
            }
            else if ((istLeben - schaden) <= 0)
            {
                istLeben = 0;
                return schaden;
            }
            else
            { return 0; }
        }

        public double Genesung()
        {
            Attacke = new HealingEffects();
            double schaden = 0;
            schaden = Attacke.angriff(staerkeG, nameG, accuG);
            if ((istLeben + schaden) < maxLeben)
            {
                istLeben = istLeben + schaden;
                return schaden;
            }
            else if ((istLeben + schaden) >= maxLeben)
            {
                istLeben = maxLeben;
                return schaden;
            }
            else
            { return (0); }
        }

        public double Leben()
        {
            double prozleben = 0;
            prozleben = istLeben / maxLeben;

            return prozleben;
        }

    }
}
