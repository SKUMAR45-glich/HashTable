using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashTable
    {
        public string Sentence { get; set; } = "To be or not to be";
        public string WordToCheck { get; set; } = "be";

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
                    var freq = map.Get(word);
                    map.Set(word, freq);
                }
            }
            int count = map.Get(WordToCheck);
            return count;
        }
    }
}
