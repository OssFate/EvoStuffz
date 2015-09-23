using System;
using System.Linq;

namespace evoStuffz
{
    class Hill
    {
        RNG rng;
        Fn f;

        public Hill()
        {
            rng = new RNG();
            f = new Fn();
        }

        public void calcHill(double[] init, double sigma)
        {
            double[] xk = init;
            double[] xy = new double[f.numVar()];

            int cont = 0;
            Console.WriteLine(cont+":   "+xk+"-"+ f.calcFitness(xk));
            while (true)
            {
                cont++;
                xy[0] = rng.gaussNumber(xk[0], sigma);
                xy[1] = rng.gaussNumber(xk[1], sigma);
                if (f.calcRestrict(xy) && (f.calcFitness(xy) < f.calcFitness(xk)))
                {
                    xk = xy;
                    xy = new double[f.numVar()];
                }
                Console.WriteLine(cont + ":   " + xk[0] + "," + xk[1] + " - " + f.calcFitness(xk));
            }
        }

        public void calcHillFifth(double[] init, double sigma, double alpha, int gmax)
        {
            double[] xk = init;
            double[] xy = new double[f.numVar()];
            int g = 0;
            int gcont = 0;
            int cont = 0;
            Console.WriteLine(cont + ":   " + xk + "-" + f.calcFitness(xk));
            while (true)
            {
                cont++;
                gcont++;
                xy[0] = rng.gaussNumber(xk[0], sigma);
                xy[1] = rng.gaussNumber(xk[1], sigma);
                if (f.calcRestrict(xy) && (f.calcFitness(xy) < f.calcFitness(xk)))
                {
                    xk = xy;
                    xy = new double[f.numVar()];
                    g++;
                }
                if(gcont == gmax)
                {
                    if (g / gmax != 0.2)
                    {
                        if (g / gmax < 0.2) sigma = sigma * alpha;
                        else sigma = sigma / alpha; 
                    }
                    gcont = 0;
                    g = 0;
                }
                Console.WriteLine(cont + ":   " + xk[0] + "," + xk[1] + " - " + f.calcFitness(xk)+ "s: "+sigma);
            }
        }

        public void calcHillPwrLaw(double[] init, double sigma, double gamma)
        {
            double[] xk = init;
            double[] xy = new double[f.numVar()];

            int cont = 0;
            Console.WriteLine(cont + ":   " + xk + "-" + f.calcFitness(xk));
            while (true)
            {
                cont++;
                xy[0] = rng.pwrlawNumber(gamma) * rng.signGen() * sigma;
                xy[1] = rng.pwrlawNumber(gamma) * rng.signGen() * sigma;
                if (f.calcRestrict(xy) && (f.calcFitness(xy) < f.calcFitness(xk)))
                {
                    xk = xy;
                    xy = new double[f.numVar()];
                }
                Console.WriteLine(cont + ":   " + xk[0] + "," + xk[1] + " - " + f.calcFitness(xk));
            }
        }

        public void calcHillParalel(double[] init, double sigma, int pop)
        {
            double[] muestra = new double[pop];
            double[][] xk = new double[pop][];
            double[] xy = new double[f.numVar()];

            for(int i = 0; i<pop; i++)
            {
                xk[i] = f.init();
            }

            int cont = 0;
            for (int n = 0; n < 5000; n++)
            {
                cont++;
                for (int i = 0; i < pop; i++)
                {
                    xy[0] = rng.gaussNumber(xk[i][0], sigma);
                    xy[1] = rng.gaussNumber(xk[i][1], sigma);
                    if (f.calcRestrict(xy) && (f.calcFitness(xy) < f.calcFitness(xk[i])))
                    {
                        xk[i] = xy;
                        xy = new double[f.numVar()];
                    }
                    muestra[i] = f.calcFitness(xk[i]);
                }
                Console.WriteLine(cont + ":  " + muestra.Max() + " - " + muestra.Min() + " - " + muestra.Average());
            }
        }
    }
}
