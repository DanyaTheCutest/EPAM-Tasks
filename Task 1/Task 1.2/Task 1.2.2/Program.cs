using System;
using System.Text;
namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string doublerString = Console.ReadLine();

            Console.WriteLine(Doubler(inputString, doublerString));
        }
        static string Doubler(string inputString, string doublerString)
        {
            StringBuilder resultString = new StringBuilder("");
            var arr = inputString.ToCharArray();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (doublerString.Contains(arr[i]) && Char.IsLetterOrDigit(arr[i]))
                    resultString.Append(arr[i].ToString() + arr[i].ToString());
                else resultString.Append(arr[i].ToString());
            }

            return resultString.ToString();
        }
    }
}
