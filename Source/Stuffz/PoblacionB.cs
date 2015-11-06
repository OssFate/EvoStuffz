using System;

namespace evoStuffz
{
	public class PoblacionB
	{
		private IndividuoB[] m_ind;
		private int pos;

		public PoblacionB(){ }

		public PoblacionB(int tam, int _pos) { m_ind = new IndividuoB[tam]; pos = _pos; }

		public PoblacionB(int tam)
		{
			m_ind = new IndividuoB[tam];
			Console.WriteLine(m_ind.Length);
		}

		public int TamPob()
		{
			return m_ind.Length;
		}

		public void init(int tam, int size)
		{
			m_ind = new IndividuoB[tam];

			for(int i = 0; i < m_ind.Length; i++)
			{
				m_ind[i] = new IndividuoB();
				m_ind[i].init(size);
			}
		}

		public IndividuoB getIndi(int index){
			return m_ind [index];
		}

		public void addIndis(IndividuoB[] ind){
			m_ind [pos] = ind [0];
			m_ind [pos + 1] = ind [1];
			pos += 2;
		}

		public void showPPL()
		{
			Console.WriteLine(m_ind.Length + " Total of ppl here:");
			for (int i = 0; i < m_ind.Length; i++)
			{
				Console.WriteLine(i + ": " + m_ind[i].showInd());
			}
		}
	}
}

