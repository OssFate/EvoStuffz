using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoStuffz
{
    public class Individuo
    {

        private Double? m_val;
        private Double[] m_value;

		public Individuo(){}
        
        public void init(int size,int[] bound)
        {
            int b = bound[1] - bound[0];
            if(size == 1)
            {
                m_val = new Double();
                m_val = (RNG.RandomNumber() * b) + bound[0];
            }
            else
            {
                m_value = new Double[size];
                for (int i = 0; i < size; i++)
                {
                    //m_value[i] = new Double();
                    m_value[i] = (RNG.RandomNumber() * b) + bound[0];
                }
            }
        }

        public string showInd()
        {
            if (m_val.HasValue)
            {
                return m_val.ToString();
            }
            else
            {
                return valueToString();
            }
        }

        private string valueToString()
        {
            string ret = "[ ";
            for(int i = 0; i < m_value.Length; i++)
            {
                ret += m_value[i];
                if(i != m_value.Length - 1)
                {
                    ret += " , ";
                }
            }
            return ret + " ]";
        }

		public double getValueIndex(int i){
			return m_value [i];
		}

		public void setValueIndex(int i, double _value){
			m_value [i] = _value;
		}

        public Double[] getValue()
        {
            return this.m_value;
        }

        public Double? getVal()
        {
            return this.m_val;
        }
    }
}
