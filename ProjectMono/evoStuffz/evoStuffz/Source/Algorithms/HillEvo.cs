﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

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
			m_pop = new Poblacion(tp);
        }

		public void AlgGen(int iter)
		{
			int i = 0;
			Poblacion Q = new Poblacion ();
			Poblacion H = new Poblacion ();
			m_pop.init (m_tp, 5, m_func);

			Stopwatch sw = Stopwatch.StartNew ();

			while(i < iter){
				//Console.WriteLine ("Time: " + sw.Elapsed);
				Q = m_sel.doSel (m_pop);
				//Q.showPPL();
				//Console.WriteLine ("Time: " + sw.Elapsed);
				H = m_crux.cruceP (Q);
				//Console.WriteLine ("Time: " + sw.Elapsed);
				m_pop = H;
				//Console.WriteLine ("Time: " + sw.Elapsed);

				m_pop.setFits (m_func);
				m_pop.setStats ();
				m_pop.showPPL ();
				//m_pop.showRun ();

				i++;
			}
			Console.WriteLine ("Time: " + sw.Elapsed);
		}

    }
}
