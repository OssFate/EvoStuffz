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
        
        public Poblacion() { }

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
