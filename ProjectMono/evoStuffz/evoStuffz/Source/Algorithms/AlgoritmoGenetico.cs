using System;

namespace evoStuffz
{
	public class AlgoritmoGenetico : AlgGenetico
	{
		Poblacion m_pop;
		int m_tp;
		AlgSelection m_sel;
		CruceYMutacion m_crux;
		MahFunc m_func;

		/*
		public AlgoritmoGenetico(int tp, AlgSelection sel, CruceYMutacion crux, MahFunc func)
		{
			m_sel = sel;
			m_crux = crux;
			m_func = func;
			m_tp = tp;
			m_pop = new Poblacion();
		}*/

		public void AlgGen(int iter)
		{
			/*
			Poblacion Q = new Poblacion ();
			Poblacion H = new Poblacion ();
			m_pop.init (m_tp, 5, m_func.getBound ());

			while(true){

				Q = m_sel.getParents (m_pop);
			}
			*/

		}

	}
}

