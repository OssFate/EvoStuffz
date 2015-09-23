using System;

namespace evoStuffz
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] bound = { -500, 500 };
            Poblacion mahPPL = new Poblacion(50);
            //mahPPL.init(100,10,bound);
            //mahPPL.showPPL();

            //float[] values = { 1, 2, 3 };

            //Console.WriteLine("Media: " + MahMath.Media(values) + " - Desviacion: " + MahMath.Desviacion(values, MahMath.Media(values)));
            Console.ReadKey();
        }

        /*
        static void Main(string[] args)
        {
            /*Fn f = new Fn();
            Console.WriteLine(f.calcRestrict(new double[] { -1, 1 }));
            Console.WriteLine(f.calcRestrict(new double[] { 0, 5 }));

            Console.ReadLine();/
            double[] x = new double[] { 1, 1 };

            Hill hill = new Hill();

            hill.calcHillParalel(x,1,20);
            //RNG rng = new RNG();
            //while(true) Console.WriteLine(rng.pwrlawNumber(2)*1*1);
            Console.ReadLine();
        }
        */
    }
}
