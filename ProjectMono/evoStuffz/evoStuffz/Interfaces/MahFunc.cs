using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    interface MahFunc
    {
        double calcFitness(Individuo x);
        int[] getBound();
    }
}
