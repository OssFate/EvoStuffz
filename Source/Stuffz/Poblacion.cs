using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    class Poblacion
    {

        private Individuo[] m_ind;
		private int pos;
        
		public Poblacion(int tam, int _pos) { m_ind = new Individuo[tam]; pos = _pos; }

        public Poblacion(int tam)
        {
            m_ind = new Individuo[tam];
            Console.WriteLine(m_ind.Length);
        }
                
        public int TamPob()
        {
            return m_ind.Length;
        }

        public void init(int tam, int size, int[] bound)
        {
            m_ind = new Individuo[tam];

            for(int i = 0; i < m_ind.Length; i++)
            {
                m_ind[i] = new Individuo();
                m_ind[i].init(size,bound);
            }
        }

		public Individuo getIndi(int index){
			return m_ind [index];
		}

		public void addIndis(Individuo[] ind){
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
