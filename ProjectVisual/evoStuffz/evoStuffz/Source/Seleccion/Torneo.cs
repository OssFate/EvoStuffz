using System;
using System.Collections.Generic;

namespace evoStuffz
{
	public class Torneo : AlgSelection
	{

		public Poblacion doSel(Poblacion pob)
		{
			Poblacion _pob = new Poblacion (pob.TamPob ());
			List<Individuo> _ind = new List<Individuo> (4);
			for (int i = 0; i < pob.TamPob (); i++) {
				for (int j = 0; j < 4; j++) {
					_ind.Add (pob.getIndi ((int)RNG.RandomNumber () * pob.TamPob ()));
				}
				_pob.addIndi (doTurney (_ind));
			}
			return _pob;
		}

		private Individuo doTurney(List<Individuo> ind)
		{
			double chance = getChance (ind [0], ind [1]);
			int i, j;
			if (RNG.RandomNumber () < chance) {
				i = 0;
			} else {
				i = 1;
			}
			chance = getChance (ind [2], ind [3]);
			if (RNG.RandomNumber () < chance) {
				j = 2;
			} else {
				j = 3;
			}
			chance = getChance (ind [i], ind [j]);
			if (RNG.RandomNumber () < chance) {
				return ind [i];
			} else {
				return ind [j];
			}
		}

		private double getChance(Individuo a, Individuo b)
		{
			double c = a.getFit () + b.getFit ();
			return a.getFit () / c;
		}

	}
}

