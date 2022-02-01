using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    public class Analysis
    {
        public string Input { get; init; }
        List<string> words = new List<string>();
        List<int> count = new List<int>();
        private int _index = 0;
        public Analysis(string input)
        {
            Input = input.Trim();
            try
            {
                Validate(Input);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string Analyze()
        {         
            var arr = Input.ToCharArray();
            var word = "";
            for (int i = 0; i < arr.Length; i++)
            {                
                if (char.IsLetterOrDigit(arr[i]))
                    word += arr[i].ToString();
                
                else if (!words.Contains(word))
                {
                    words.Add(word);
                    count.Add(1);
                    word = "";
                } 
                else 
                {
                    count[words.IndexOf(word)]++;
                    word = "";
                }
                if (i == arr.Length - 1)
                {
                    if (!words.Contains(word))
                    {
                        words.Add(word);
                        count.Add(1);
                        word = "";
                    }
                    else
                    {
                        count[words.IndexOf(word)]++;
                        word = "";
                    }
                }

            }           
            var max = FindMax();                        
            if (max <= 1)
                return "Congrats, you are the originality itself";
            else return $"Not really original :( The word {words[_index]} appears {max} times";
        }

        private void Validate(string input)
        {
            if (input == "" || input == null)
                throw new ArgumentException("The string can not be empty");
        }

        private int FindMax()
        {
            int max = 1;
            for (int i = 0; i < words.Count; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    _index = i;
                }                   
            }
            return max;
        }       
    }
}
