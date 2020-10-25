using System;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            Console.WriteLine($"Frequency of \"{hashTable.WordToCheck}\" is {hashTable.FindFrequencyOfWord()}");

        }
    }
}
