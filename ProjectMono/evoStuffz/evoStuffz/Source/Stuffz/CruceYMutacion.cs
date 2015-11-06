using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    class CruceYMutacion
    {

		private double pCruce;
		private double pMuta;
		private Mutacion mut;

		public CruceYMutacion(double _pCruce, double _pMuta, Mutacion _mut){
			pCruce = _pCruce;
			pMuta = _pMuta;
			mut = _mut;
		}

        public Poblacion cruceP(Poblacion p)
        {
			Poblacion H = new Poblacion(p.TamPob ());
			//Console.WriteLine ("Cruce ------>>>> TAMAÑO DE LA POBLACION!!!  -->  " + p.TamPob() );
			List<Individuo> ind;

			for(int i = 0; i < p.TamPob (); i+=2)
			{
				ind = new List<Individuo> (2);
				if (RNG.RandomNumber () < pCruce) {
					ind = cruceI (p.getIndi (i), p.getIndi (i + 1));
				} else {
					ind.Add (p.getIndi (i));
					ind.Add (p.getIndi (i + 1));
				}
				//Console.WriteLine ("---->> " + ind.Count);
				mutacion (ind);
				H.addIndis (ind);
				//Console.WriteLine (i + " ---->>>>>  " + p.TamPob() + " -----> " + H.TamPob());
 				//Console.WriteLine ("CruceFinal ------>>>> TAMAÑO DE LA POBLACION!!!  -->  " + H.TamPob() );
			}
            return H;
        }

		public List<Individuo> cruceI(Individuo i, Individuo j)
		{
			int index = (int) (RNG.RandomNumber () * (i.getValue ().Length - 1)) + 1;
			List<Individuo> ind = new List<Individuo>(2);
			ind.Add (i); ind.Add (j);
			for(int k = index; k < i.getValue ().Length; k++){
				ind [0].setValueIndex (k, j.getValueIndex (k));
				ind [1].setValueIndex (k, i.getValueIndex (k));
			}
			return ind;
		}

		public void mutacion(List<Individuo> indi)
		{
			if (indi [0].getVal ().HasValue) {
				if (RNG.RandomNumber () < pMuta) {
					mut.doMutis ((double) indi[0].getVal ());
				}
				if (RNG.RandomNumber () < pMuta) {
					mut.doMutis ((double) indi[1].getVal ());
				}
			} else {
				for (int i = 0; i < indi [0].getValue ().Length; i++) {
					if (RNG.RandomNumber () < pMuta) {
						indi[0].setValueIndex(i , mut.doMutis (indi [0].getValueIndex (i)));
					}
					if (RNG.RandomNumber () < pMuta) {
						indi[1].setValueIndex(i, mut.doMutis (indi [1].getValueIndex (i)));
					}
				}
			}
		}
    }
}
