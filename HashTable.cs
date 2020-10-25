using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashTable
    {
        public string Sentence { get; set; } = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        public string WordToCheck { get; set; } = "paranoid";
        
            
        public int FindFrequencyOfWord()
        {
            string[] words = Sentence.Split(' ');
            MyMapNode<string, int> map = new MyMapNode<string, int>(10);

            foreach (string word in words)
            {
                if (map.Get(word) == 0)
                    map.Add(word, 1);
                else
                {
                    var freq = map.Get(word) + 1;
                    map.Set(word, freq);
                }
            }
            int count = map.Get(WordToCheck);
            return count;
        }
    }
}
