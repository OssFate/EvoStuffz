using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    class Fn : MahFunc
    {
        public double calcFitness(Individuo x)
        {
			double sum = 0;
			for (int i = 0; i < x.getValue ().Length; i++) {
				sum += Math.Pow (x.getValueIndex (i), 2);
			}
			return sum;
        }
        
        public bool calcRestrict(Individuo x)
        {
			bool r1 = (-1 * x.getValueIndex (0) <= 0);
			bool r2 = (-1 * x.getValueIndex (1) <= 0);
			bool r3 = (x.getValueIndex (0) + x.getValueIndex (1) - 4 <= 0);

            return (r1 && r2 && r3);
        }

        public int[] getBound()
        {
			return new int[] {0, 100};
        }

		public int calcFitness (IndividuoB x) {
			return 0;
		}
    }
}
