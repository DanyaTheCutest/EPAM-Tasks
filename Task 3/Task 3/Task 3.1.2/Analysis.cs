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
        List<Word> words = new List<Word>();
        private int _index = 0;
        public Analysis(string input)
        {
            Input = input.Trim();           
        }
        public string Analyze()
        {         
            var arr = Input.ToCharArray();
            string word = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetterOrDigit(arr[i]))
                    word += arr[i].ToString();
                else if (!words.Contains(new Word(word)))
                {
                    words.Add(new Word(word));
                    word = "";
                }
                else
                {
                    words[words.IndexOf(new Word(word))].incrementCount();
                    word = "";
                }
            }
            var max = FindMax();
            Console.WriteLine("" + max + " " + _index);
            if (max <= 1)
                return "Congrats, you are the originality itself";
            else return $"Not really original :( The word {words[_index]} appears {max} times";
        }

        private int FindMax()
        {
            int max = words[0].Count;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Count > max)
                {
                    max = words[i].Count;
                    _index = i;
                }
                    
            }
            return max;
        }
    }
}
