using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public static void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                int temp = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    
                    if(arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

            }
        }

        public static void Insertion(int[] arr)
        {
            int i = 1;
            while (i < arr.Length)
            {
                int temp = arr[i];
                int j = i-1;
                
                while (j >= 0 && arr[j] > temp)
                {
                    //int temp = arr[j];
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = temp;
                i++;
            }
        }

        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            //Finding a midpoint
            decimal midPoint = arr.Length / 2;
            var mid = Convert.ToInt32(Math.Ceiling(midPoint));

            //Chop into arrays
            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray();

            //MergeSort each array;
            var botOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var combined = Combine(botOut, topOut);

            return combined;
        }

        private static int[] Combine(int[] bottom, int[] top)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var arr = new int[bottom.Length + top.Length];

            while (i < bottom.Length && j < top.Length)
            {
                if (bottom[i] < top[j])
                {
                    arr[k] = bottom[i];
                    i++;
                }
                else
                {
                    arr[k] = top[j];
                    j++;
                }
                k++;
            }
            while (i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }
            while (j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }

            return arr;
        }
    }
}
