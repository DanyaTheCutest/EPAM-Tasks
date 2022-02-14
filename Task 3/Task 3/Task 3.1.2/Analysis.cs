using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    public class Analysis
    {
        private string _maxWord = "";
        public string Input { get; init; }
        Dictionary<string, int> words = new Dictionary<string, int>();
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
                
                else if (!words.ContainsKey(word))
                {
                    words.Add(word,1);
                    word = "";
                } 
                else 
                {
                    words[word]++;
                    word = "";
                }
                if (i == arr.Length - 1)
                {
                    if (!words.ContainsKey(word))
                    {
                        words.Add(word,1);
                        word = "";
                    }
                    else
                    {
                        words[word]++;
                        word = "";
                    }
                }

            }           
            var max = FindMax();                        
            if (max <= 1)
                return "Congrats, you are the originality itself";
            else return $"Not really original :( The word {_maxWord} appears {max} times";
        }

        private void Validate(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("The string can not be empty");
        }

        private int FindMax()
        {
            int max = 1;
            foreach (var item in words)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    _index++;
                    _maxWord = item.Key;
                }
            }
            return max;
        }       
    }
}
