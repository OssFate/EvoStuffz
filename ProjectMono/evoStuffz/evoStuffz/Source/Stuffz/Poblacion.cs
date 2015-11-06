using System;
using System.Collections.Generic;

namespace evoStuffz
{
    public class Poblacion
    {

		//private Individuo[] m_ind;
		private List<Individuo> m_ind;

		private double m_min;
		private double m_max;
		//private double m_med;
		private double m_mean;
		private double m_std;

		public Poblacion() {}

		public Poblacion(int tam)
		{
			m_ind = new List<Individuo>(tam);
			//Console.WriteLine(m_ind.Capacity);
		}

		public int TamPob()
		{
			return m_ind.Count;
		}

		public void init(int tam, int size, MahFunc func)
		{
			m_ind = new List<Individuo>(tam);

			for(int i = 0; i < m_ind.Capacity; i++)
			{
				m_ind.Add (new Individuo(size, func));
			}
		}

		public Individuo getIndi(int index){
			return m_ind [index];
		}

		public void addIndis(List<Individuo> ind){
			m_ind.AddRange (ind);
		}

		public void addIndi(Individuo ind)
		{
			m_ind.Add (ind);
		}

		public void setFits(MahFunc func)
		{
			for (int i = 0; i < m_ind.Count; i++) {
				m_ind [i].setFit (func);
			}
		}

		public void setStats()
		{
			m_min = m_ind [0].getFit ();
			m_max = m_ind [0].getFit ();

			double fit;
			for (int i = 0; i < m_ind.Count; i++) {
				fit = m_ind [i].getFit ();
				// Media
				m_mean += fit;
				// Optimo (minimo)
				if (fit < m_min)
					m_min = fit;
				// Max
				if (fit > m_max)
					m_max = fit;
			}
			m_mean /= m_ind.Capacity;
			//Desviacion
			for (int i = 0; i < m_ind.Count; i++) {
				fit = m_ind [i].getFit ();
				m_std += Math.Pow (fit - m_mean, 2);
			}
			m_std = Math.Sqrt (m_std / m_ind.Capacity);
		}

		public void showPPL()
		{
			Console.WriteLine(m_ind.Count + " Total of ppl here:");
			for (int i = 0; i < m_ind.Capacity; i++)
			{
				Console.WriteLine(i + ": " + m_ind[i].showInd());
			}
		}

		public void showRun()
		{
			//Console.WriteLine (m_ind.Count + " Total of ppl here:");
			Console.WriteLine ("Best: " + m_min + " Worst: " + m_max + " Media: " + m_mean + " Desviacion: " + m_std);
		}
    }
}
