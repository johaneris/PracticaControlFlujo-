using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros2.models
{
    public class Numeritos
    {
        private int[] numbers = new int[100];
        private int index = 0;

        public void AddElement(int number)
        {
            if (index < 100)
            {
                numbers[index] = number;
                index++;
            }
        }

        public int[] GetElements()
        {
            return numbers;
        }

        public int GetIndex()
        {
            return index;
        }

        public int SumElements()
        {
            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int GetMaxElement()
        {
            int max = numbers[0];
            for (int i = 1; i < index; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public int GetMinElement()
        {
            int min = numbers[0];
            for (int i = 1; i < index; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}
