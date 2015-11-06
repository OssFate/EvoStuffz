using System;

namespace evoStuffz
{
	public class FSchwefel: MahFunc
	{
		public double calcFitness(Individuo x) {
			double fit = 418.9829 * x.getValue().Length;
			double sum = 0;
			for (int i = 0; i < x.getValue ().Length; i++) {
				sum += -x.getValueIndex (i) * Math.Sin (Math.Sqrt (Math.Abs (x.getValueIndex (i))));
			}
			return (fit + sum);
		}

		public int calcFitness (IndividuoB x) {
			return 0;
		}

		public int[] getBound() {
			return new int[] {-512, 512};
		}
	}
}

