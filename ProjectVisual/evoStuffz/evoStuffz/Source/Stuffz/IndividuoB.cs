using System;

namespace evoStuffz
{
	public class IndividuoB
	{
		
		private int[] m_value;

		public void init(int size)
		{
			m_value = new int[size];
			for (int i = 0; i < size; i++)
			{
				if (RNG.RandomNumber () < 0.5)
					m_value [i] = 0;
				else
					m_value [i] = 1;
			}
		}

		public string showInd()
		{
			return valueToString();
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

		public void setValueIndex(int i, int _value){
			m_value [i] = _value;
		}

		public int[] getValue()
		{
			return this.m_value;
		}
	}
}

