﻿using System;
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
                if (map.Get(word) == 0)
                    map.Add(word, 1);
                else
                {
                    var freq = map.GetValue(word) + 1;
                    map.Set(word, freq);
                }
            }
            int count = map.Get(WordToCheck);
            myMap = map;
            return count;
        }

        public void RemoveWord(string wordToRemove)
        {
            MyMapNode<string, int> map = myMap;
            map.RemoveValue(wordToRemove);
            int count = map.GetValue(wordToRemove);
            Console.WriteLine("Frequency of+"wordToRemove+ "after removal is "+count);
        }
    }
}
