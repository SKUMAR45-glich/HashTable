using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashTable
    {
        public string Sentence { get; set; } = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        public string WordToCheck { get; set; } = "paranoid";
        
        public MyMapNode<string, int> myMap;
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
            myMap = map;
            return count;
        }

        public void RemoveWord(string wordToRemove)
        {
            MyMapNode<string, int> map = myMap;
            map.RemoveValue(wordToRemove);
            Console.WriteLine($"Frequency of \"{wordToRemove}\" after removal is {map.GetValue(wordToRemove)} ");
        }
    }
}
