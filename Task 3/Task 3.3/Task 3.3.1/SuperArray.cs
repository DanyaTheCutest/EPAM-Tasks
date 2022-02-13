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
            return sum / arr.Count();
        }

        public static int FindMostCommon(this int[] arr)
        {
            return arr.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
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
