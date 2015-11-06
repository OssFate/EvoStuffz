using System;

namespace evoStuffz
{
	public class gaussMut : Mutacion
	{
		private double sigma;

		public gaussMut(double _sigma) {
			this.sigma = _sigma;
		}
		
		public double doMutis(double d) {
			double u1 = RNG.RandomNumber (); //these are uniform(0,1) random doubles
			double u2 = RNG.RandomNumber ();
			double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
			double randNormal = d + sigma * randStdNormal; //random normal(mean,stdDev^2)
			//Console.WriteLine ("----------------------------->>>>>>>>>>Did mutation: " + randNormal);
			return randNormal;
		}
	}
}

