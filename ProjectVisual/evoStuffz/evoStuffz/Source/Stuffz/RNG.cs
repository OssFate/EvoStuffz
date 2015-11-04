using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    class RNG : Random
    {
        public RNG() {}

        public double gaussNumber( double mean, double stdDev )
        {
            double u1 = this.NextDouble(); //these are uniform(0,1) random doubles
            double u2 = this.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
            return randNormal;
        }

        public double pwrlawNumber(double gamma)
        {
            return 1.0 / Math.Pow(1 - this.NextDouble(), 1.0 / (gamma + 1));
        }

        public int signGen()
        {
            double s = this.NextDouble();
            if (s < 0.5) return 1;
            else return -1;
        }

        //Function to get random number
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static double RandomNumber()
        {
            lock (syncLock)
            { // synchronize
                return random.NextDouble();
            }
        }
    }
}
