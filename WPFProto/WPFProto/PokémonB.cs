using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProto
{
    public class PokémonB : Pokémon
    {
        public double istLeben = maxLeben;
        public static double maxLeben = 180;

        public int staerkeR = 25;
        public string nameR = "Rasierblatt";
        public double accuR = 70;

        public int staerkeT = 15;
        public string nameT = "Tackle";
        public double accuT = 80;

        public int staerkeG = 30;
        public string nameG = "Genesung";
        public double accuG = 40;

        public double Rasierblatt()
        {
            Attacke = new NormalAttack();
            double schaden = Attacke.angriff(staerkeR, nameR, accuR);
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
            double schaden = Attacke.angriff(staerkeT, nameT, accuT);
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
            double schaden = Attacke.angriff(staerkeG, nameG, accuG);
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
            { return 0; }
        }

        public double Leben()
        {
            double prozleben = 0;
            if (istLeben < maxLeben)
            {
                prozleben = istLeben / maxLeben;
                return prozleben;
            }
            else if (istLeben == maxLeben)
            {
                prozleben = 1;
                return prozleben;
            }
            else
            { return 0; }
        }

    }
}
