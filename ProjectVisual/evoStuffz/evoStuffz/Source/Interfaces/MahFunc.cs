﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    public interface MahFunc
    {
        double calcFitness(Individuo x);
		int calcFitness (IndividuoB x);
        int[] getBound();
    }
}
