using System;
using System.Collections.Generic;

public class Autocorrect
{
    public static List<List<string>> GetSearchResults(List<string> words, List<string> queries)
    {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        foreach (string word in words)
        {
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            string sortedWord = new string(letters);
            if (!anagrams.ContainsKey(sortedWord))
            {
                anagrams[sortedWord] = new List<string>();
            }

            anagrams[sortedWord].Add(word);
        }

        List<List<string>> results = new List<List<string>>();
        foreach (string query in queries)
        {
            char[] letters = query.ToCharArray();
            Array.Sort(letters);
            string sortedQuery = new string(letters);
            if (anagrams.ContainsKey(sortedQuery))
            {
                List<string> result = anagrams[sortedQuery];
                result.Sort();
                results.Add(result);
            }
            else
            {
                results.Add(new List<string>());
            }
        }
        return results;
    }
}

// Izafr- 14 TC PAss