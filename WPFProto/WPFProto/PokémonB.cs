using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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

        public int staerkeFo = 0;
        public string nameFo = "Focus";
        public double accuFo = 100;
        public double zusatz = 0;
        
        public double schaden = 0;

        public double Focus()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Philipp\Documents\2014-15\PPM\Köllö\Projekt_UrPokemon\sounds\Focus.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

            Attacke = new StatusAttack();

            zusatz = Attacke.angriff(staerkeFo, nameFo, accuFo);

            return zusatz;

        }

        public double Rasierblatt()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Philipp\Documents\2014-15\PPM\Köllö\Projekt_UrPokemon\sounds\Rasier.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

            Attacke = new NormalAttack();
            schaden = Attacke.angriff(staerkeR, nameR, accuR);
            if (schaden > 0)
            {
                schaden = schaden + zusatz;
            }
            else
            {
                schaden = 0;
            }

            if ((istLeben - schaden) > 0)
            {
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
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Philipp\Documents\2014-15\PPM\Köllö\Projekt_UrPokemon\sounds\Tackle.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

            Attacke = new NormalAttack();
            schaden = Attacke.angriff(staerkeT, nameT, accuT);
            if (schaden > 0)
            {
                schaden = schaden + zusatz;
            }
            else
            {
                schaden = 0;
            }

            if ((istLeben - schaden) > 0)
            {
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
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Philipp\Documents\2014-15\PPM\Köllö\Projekt_UrPokemon\sounds\Genesung.wav");
            try
            {
                simpleSound.Play();
            }
            catch
            {
            }

            Attacke = new HealingEffects();
            schaden = Attacke.angriff(staerkeG, nameG, accuG);
            if (schaden > 0)
            {
                schaden = schaden + zusatz;
            }
            else
            {
                schaden = 0;
            }

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
