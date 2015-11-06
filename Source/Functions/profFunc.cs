using System;

namespace evoStuffz
{
	public class profFunc : MahFunc
	{
		public static int it;

		public profFunc(){
			it = 0;
		}
		
		public double calcFitness(Individuo x) {
			double value = 0;
			if (it < 100) {
				for (int i = 0; i < x.getValue ().Length; i++) {
					value += Math.Pow (x.getValueIndex (i), 2) + x.getValueIndex (i) + 3;
				}
			} else {
				if (it < 200) {
					for (int i = 0; i < x.getValue ().Length; i++) {
						value += Math.Pow (x.getValueIndex (i), 3) - (2 * Math.Pow (x.getValueIndex (i), 2)) + 3;
					}
				} else {
					for (int i = 0; i < x.getValue ().Length; i++) {
						value = Math.Pow (x.getValueIndex (i), 2) - (3 * x.getValueIndex (i)) + 2;
					}
				}
			}
			return value;
		}

		public int calcFitness (IndividuoB x) {
			return 0;
		}

		public int[] getBound(){
			int[] b = { -100, 100 };
			return b;
		}

		public static void upIT(){
			profFunc.it++;
			if (it == 300)
				it = 0;
		}
	}
		
}

