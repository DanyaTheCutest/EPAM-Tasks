using System;

namespace Task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySuperString = new char[11] { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
            var mySuperString_2 = new char[1] { 'a' };

            MyOwnString myString = new MyOwnString(mySuperString);
            MyOwnString myString_2 = new MyOwnString(mySuperString_2);
            MyOwnString concatResultString = new MyOwnString(myString.ConcatStrings(myString_2));

            Console.WriteLine(concatResultString.ToString());
            
            

        }
    }
}
