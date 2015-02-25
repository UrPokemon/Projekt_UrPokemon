using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WPFProto
{
    public class PokémonA : Pokémon 
    {
        public double istLeben = PokémonB.maxGLeben;
        public double maxLeben = PokémonB.maxGLeben;

        public double istGLeben = maxGLeben;
        public static double maxGLeben=150;

        public int staerkeF = 35;
        public string nameF = "Flammenwurf";
        public double accuF = 60;

        public int staerkeT = 15;
        public string nameT = "Tackle";
        public double accuT = 80;

        public int staerkeG = 30;
        public string nameG = "Genesung";
        public double accuG = 40;

        public int staerkeB = -10;
        public string nameB = "Brüller";
        public double accuB = 80;
        public double brull = 0;

        public double Brüller()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Users\Fabian\Documents\Schule 5BHWII 2014-15\PPM\Köllö\sounds\Brüller.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }
            Attacke = new StatusAttack();
            brull = Attacke.angriff(staerkeB, nameB, accuB);

            return brull;
        }

        public double Flammenwurf()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Users\Fabian\Documents\Schule 5BHWII 2014-15\PPM\Köllö\sounds\Flammen.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

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
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Users\Fabian\Documents\Schule 5BHWII 2014-15\PPM\Köllö\sounds\Tackle.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

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
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Users\Fabian\Documents\Schule 5BHWII 2014-15\PPM\Köllö\sounds\Genesung.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

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
