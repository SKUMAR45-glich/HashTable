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
                if (map.GetValue(word) == 0)
                    map.AddValue(word, 1);
                else
                {
                    var freq = map.GetValue(word) + 1;
                    map.SetValue(word, freq);
                }
            }
            int count = map.GetValue(WordToCheck);
            return count;
        }
    }
}
