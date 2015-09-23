using System;

namespace evoStuffz
{
    class MahMath
    {
        public static float Media(float[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public static float Desviacion(float[] array, float media)
        {
            float sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += (float) Math.Pow(array[i] - media, 2);
            }
            return (float) Math.Sqrt(sum / array.Length);
        }
    }
}