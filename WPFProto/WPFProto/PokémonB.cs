using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProto
{
    public class PokémonB : Pokémon
    {
        public double istLeben = PokémonA.maxGLeben;
        public static double maxLeben = PokémonA.maxGLeben;

        public double istGLeben = maxGLeben;
        public static double maxGLeben = 180;

        public int staerkeR = 25;
        public string nameR = "Rasierblatt";
        public double accuR = 70;

        public int staerkeT = 15;
        public string nameT = "Tackle";
        public double accuT = 80;

        public int staerkeG = 20;
        public string nameG = "Erholung";
        public double accuG = 50;

        public double Rasierblatt()
        {
            Attacke = new NormalAttack();
            double schaden = 0;
            schaden = Attacke.angriff(staerkeR, nameR, accuR);
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
            { return 0; }
        }

        public double Leben()
        {
            double prozleben = 0;
            
            prozleben = istLeben / maxLeben;
            return prozleben;
            
        }

    }
}
