using System;
using System.Collections.Generic;

namespace evoStuffz
{
    public class Poblacion
    {

		//private Individuo[] m_ind;
		private List<Individuo> m_ind;

		private double m_opt = 10000000;
		private double m_mean;
		private double m_des;

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

		public void setStats()
		{
			double fit;
			for (int i = 0; i < m_ind.Count; i++) {
				fit = m_ind [i].getFit ();
				// Media
				m_mean += fit;
				// Optimo
				if (fit < m_opt)
					m_opt = fit;
			}
			m_mean /= m_ind.Capacity;
			//Desviacion
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
			Console.WriteLine ("Best: " + m_opt + " Media: " + m_mean);
		}
    }
}
