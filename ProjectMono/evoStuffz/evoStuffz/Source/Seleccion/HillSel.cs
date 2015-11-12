using System;
using System.Collections.Generic;

namespace evoStuffz
{	
	public class HillSel: AlgSelection
	{

		public Poblacion doSel(Poblacion pob)
		{
			return new Poblacion ();
		}

		public Poblacion doSel (Poblacion pA, Poblacion pB)
		{
			List<Individuo> _ind;
			Poblacion _pob = new Poblacion (pA.TamPob ());

			for (int i = 0; i < pA.TamPob (); i += 2) {
				_ind = new List<Individuo> (2);
				if (pA.getIndi (i).getFit () < pB.getIndi (i).getFit ()) {
					_ind.Add (pA.getIndi (i));
				} else {
					_ind.Add (pB.getIndi (i));
				}

				if (pA.getIndi (i+1).getFit () < pB.getIndi (i+1).getFit ()) {
					_ind.Add (pA.getIndi (i+1));
				} else {
					_ind.Add (pB.getIndi (i+1));
				}
				_pob.addIndis (_ind);
			}
			return _pob;
		}

	}
}

