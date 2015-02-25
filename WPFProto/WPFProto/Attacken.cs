using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProto
{
    class NormalAttack : ITFAttacken
    {
        static Random Rnd = new Random();
        double acc = Rnd.Next(0, 100);
        double astaerke;

        public double angriff(double stärke, string name, double accuracy)
        {
            astaerke = 0;
            double schwank = Rnd.Next(-5, +5);

            if (acc <= accuracy)
            {
                astaerke = stärke + (schwank);
                return astaerke;

            }
            else
            {
                astaerke = 0.0;
                return astaerke;
            }
        }
    }

    class HealingEffects : ITFAttacken                                             //Attacken die einen heilenden Effekt haben
    {
        static Random Rnd = new Random();
        double acc = Rnd.Next(0, 100);

        double schwank = Rnd.Next(-10, +10);
        double statusdiff = 0.0;

        public double angriff(double stärke, string name, double accuracy)
        {
            statusdiff = 0.0;

            if (acc <= accuracy)
            {
                statusdiff = stärke + (schwank);
                return statusdiff;
            }
            else
            {
                statusdiff = 0.0;
                return statusdiff;
            }

        }
    }

    class StatusAttack : ITFAttacken                                                 // Statusattacken sollen den Gegner bzw. sich selbst beeinflussen, kommt noch
    {
        static Random Rnd = new Random();
        double acc = Rnd.Next(0, 100);
        double rand = Rnd.Next(0, 100);
        double starke = 0;

        
        public double angriff(double stärke, string name, double accuracy)
        {
            if (acc <= accuracy)
            {
                if (rand <= 50)
                {
                    starke = 15;
                }
                else if ((rand <= 75) && (rand > 50))
                {
                    starke = 20;
                }
                else if ((rand <= 85) && (rand > 75))
                {
                    starke = 25;
                }
                else if ((rand <= 93) && (rand > 85))
                {
                    starke = 30;
                }
                else if ((rand <= 97) && (rand > 93))
                {
                    starke = 35;
                }
                else
                {
                    starke = 40;
                }
            }
            else
            {
                starke = 0;
            }

            return starke;
        }

    }

/*
    class DoubleAttack : ITFAttacken                                                 // Attacken die über mehrere Züge gehen, kommt noch
    {
        public void angriff(double stärke, string name, double accuracy)
        {

        }
    }*/
}
