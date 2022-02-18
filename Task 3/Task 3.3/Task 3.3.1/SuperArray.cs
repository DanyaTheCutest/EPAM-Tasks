using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._1
{
    public static class SuperArray
    {
        public static int FindSum(this int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        
        public static int FindAverage(this int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        public static int FindMostCommon(this int[] arr)
        {
            var max = 1;
            var maxItem = 0;
            var dictionary = new Dictionary<int,int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dictionary.ContainsKey(arr[i]))
                    dictionary.Add(arr[i], 1);
                else dictionary[arr[i]]++;                
            }
            foreach (var item in dictionary)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    maxItem = item.Key;
                }
            }
            return maxItem;
        }

        public static int[] ApplyToMass(this int[] arr, Func<int, int> func)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = func(arr[i]);
            }
            return arr;
        }
    }
}
