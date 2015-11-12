using System;

namespace evoStuffz
{
    public interface AlgSelection
    {
		Poblacion doSel (Poblacion pob);
		Poblacion doSel (Poblacion pA, Poblacion pB);
    }
}
