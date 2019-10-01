using System;
using Wordplay;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string input = Console.ReadLine();
        Anagram anagram = new Anagram();
        Console.WriteLine(anagram.FindAnagrams(input));
    }
}