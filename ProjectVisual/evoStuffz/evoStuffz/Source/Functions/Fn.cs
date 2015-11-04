using System;

namespace evoStuffz
{
    class Fn : MahFunc
    {
        public double calcFitness(Individuo x)
        {
            return Math.Pow(x.getValue()[0], 2) - Math.Pow(x.getValue()[1], 2);
        }
        
        public bool calcRestrict(Individuo x)
        {
            bool r1 = (-1*x.getValue()[0] <= 0);
            bool r2 = (-1*x.getValue()[1] <= 0);
            bool r3 = (x.getValue()[0] + x.getValue()[1] - 4 <= 0);

            return (r1 && r2 && r3);
        }

        public int[] getBound()
        {
            int[] b = { 0, 100 };
            return b;
        }
    }
}
