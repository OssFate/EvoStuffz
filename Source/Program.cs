using System;

namespace evoStuffz
{
    class Program
    {
		
		static void Main(String[] args)
		{
			MahFunc m_fn = new profFunc ();
			AlgGenetico auto;
			AlgSelection m_sel = new Torneo ();
			CruceYMutacion x = new CruceYMutacion(0.8, 0.8, new gaussMut(2));

			auto = new HillEvo (100, m_sel, x, m_fn);

			auto.AlgGen (1000);

		}
		
		/*
        static void Main(string[] args)
        {
            int[] bound = { -100, 100 };
            Poblacion mahPPL = new Poblacion(50);
            mahPPL.init(20,3,bound);
            mahPPL.showPPL();

            //float[] values = { 1, 2, 3 };

            //Console.WriteLine("Media: " + MahMath.Media(values) + " - Desviacion: " + MahMath.Desviacion(values, MahMath.Media(values)));
            //Console.ReadKey();
        }
		*/

        /*
        static void Main(string[] args)
        {
            Fn f = new Fn();
            Console.WriteLine(f.calcRestrict(new double[] { -1, 1 }));
            Console.WriteLine(f.calcRestrict(new double[] { 0, 5 }));

            Console.ReadLine();
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
