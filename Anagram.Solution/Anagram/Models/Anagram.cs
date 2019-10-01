using System;
using System.Text.RegularExpressions;

namespace Wordplay
{
    public class Anagram
    {
        public string FindAnagrams(string input)
        {
            string output = "";
            Regex regex = new Regex(@"[^a-zA-Z]");
            Match match = regex.Match(input);
            if (match.Success){
               output = "Alphabetical input only. Please try again.";
            }
            return output;
        }
    }
}