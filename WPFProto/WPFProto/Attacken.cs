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

        double schwank = Rnd.Next(-5, +5);
        double astaerke;

        public double angriff(double stärke, string name, double accuracy)
        {
            astaerke = 0;

            if (acc <= accuracy)
            {
                astaerke = stärke + schwank;
                return astaerke;

            }
            else
            {
                astaerke = 0;
                return astaerke;
            }
        }
    }

    class HealingEffects : ITFAttacken                                             //Attacken die einen heilenden Effekt haben
    {
        static Random Rnd = new Random();
        double acc = Rnd.Next(0, 100);

        double schwank = Rnd.Next(-10, +10);
        double statusdiff = 0;

        public double angriff(double stärke, string name, double accuracy)
        {
            statusdiff = 0;

            if (acc <= accuracy)
            {
                statusdiff = stärke + schwank;
                return statusdiff;
            }
            else
            {
                statusdiff = 0;
                return statusdiff;
            }

        }
    }

    /*class StatusAttack : ITFAttacken                                                 // Statusattacken sollen den Gegner bzw. sich selbst beeinflussen, kommt noch
    {
        public void angriff(double stärke, string name, double accuracy)
        {

        }
    }


    class DoubleAttack : ITFAttacken                                                 // Attacken die über mehrere Züge gehen, kommt noch
    {
        public void angriff(double stärke, string name, double accuracy)
        {

        }
    }*/
}
