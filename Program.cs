using System;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            string wTc = hashTable.WordToCheck;
            int frequency = hashTable.FindFrequencyOfWord();

            Console.WriteLine("Frequency of"+wTc+" is "+frequency);

        }
    }
}
