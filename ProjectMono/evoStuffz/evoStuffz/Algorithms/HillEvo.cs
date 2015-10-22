using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    class HillEvo : AlgGenetico
    {

        private Poblacion m_pop;
        private int m_tp;
        //private AlgSelection m_sel;
        private CruceYMutacion m_crux;
        private MahFunc m_func;

        public HillEvo(int tp, /*AlgSelection sel,*/ CruceYMutacion crux, MahFunc func)
        {
            //m_sel = sel;
            m_crux = crux;
            m_func = func;
            m_tp = tp;
			m_pop = new Poblacion(tp);
        }

		public void AlgGen(int iter)
		{
			int i = 0;
			Poblacion Q = new Poblacion ();
			Poblacion H = new Poblacion ();
			m_pop.init (m_tp, 5, m_func.getBound ());

			while(i < iter){

				Q = m_pop;
				H = m_crux.cruceP (Q);
				m_pop = H;

				i++;
			}
		}

    }
}
