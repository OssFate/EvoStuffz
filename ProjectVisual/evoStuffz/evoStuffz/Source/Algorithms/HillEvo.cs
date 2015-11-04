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
        private AlgSelection m_sel;
        private CruceYMutacion m_crux;
        private MahFunc m_func;

        public HillEvo(int tp, AlgSelection sel, CruceYMutacion crux, MahFunc func)
        {
            m_sel = sel;
            m_crux = crux;
            m_func = func;
            m_tp = tp;
            m_pop = new Poblacion();
        }

    }
}
