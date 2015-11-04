using System;
using System.Collections.Generic;

namespace evoStuffz
{
    class Poblacion
    {
        /// <summary>
        /// Lista de individuos
        /// </summary>
        private List<Individuo> m_ind;

        /// <summary>
        /// Constructor de Poblacion vacio
        /// </summary>
        public Poblacion() { }

        /// <summary>
        /// Constructor de la poblacion, iniciando la lista de individuos con un tamaño predefinido.
        /// </summary>
        /// <param name="tam">Tamaño de la poblacion</param>
        public Poblacion(int tam)
        {
            m_ind = new List<Individuo>(tam);
            Console.WriteLine(m_ind.Capacity);
        }

        /// <summary>
        /// Constructor de la poblacion con una lista completa.
        /// </summary>
        /// <param name="ppl">Lista de individuos</param>
        public Poblacion(List<Individuo> ppl)
        {
            m_ind = new List<Individuo>(ppl);
        }

        /// <summary>
        /// Retorna el tamaño de la poblacion.
        /// </summary>
        /// <returns>Entero</returns>
        public int TamPob()
        {
            return m_ind.Capacity;
        }

        /// <summary>
        /// Inicializa la poblacion con los parametros dados.
        /// </summary>
        /// <param name="tam">Tamaño de la poblacion</param>
        /// <param name="size">Numero de elementos que cada individuo de la poblacion posee</param>
        /// <param name="bound">Limite de valores que cada individuo de la poblacion puede tener</param>
        public void init(int tam, int size, int[] bound)
        {
            m_ind = new List<Individuo>(tam);

            for (int i = 0; i < m_ind.Capacity; i++)
            {
                m_ind.Add(new Individuo(size, bound));
            }
        }

        /// <summary>
        /// Retorna un individuo de la poblacion actual.
        /// </summary>
        /// <param name="index">Indice del individuo a retornar.</param>
        /// <returns>Individuo</returns>
        public Individuo getIndi(int index)
        {
            return m_ind[index];
        }

        /// <summary>
        /// Agrega un arreglo de individuos a la poblacion.
        /// </summary>
        /// <param name="ind">Arreglo de Individuos</param>
        public void addIndis(Individuo[] ind)
        {
            foreach (Individuo j in ind)
            {
                m_ind.Add(j);
            }
        }

        /// <summary>
        /// Agrega un individuo a la poblacion.
        /// </summary>
        /// <param name="ind"></param>
        public void addInd(Individuo ind)
        {
            m_ind.Add(ind);
        }

        /// <summary>
        /// Funcion para mostrar la poblacion con cada uno de sus individuos.
        /// </summary>
        public void showPPL()
        {
            Console.WriteLine(m_ind.Count + " Total of ppl here:");
            for (int i = 0; i < m_ind.Count; i++)
            {
                Console.WriteLine(i + ": " + m_ind[i].showInd());
            }
        }
    }
}
