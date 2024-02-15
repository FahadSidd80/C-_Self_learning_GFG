using System;
using System.Collections.Generic;
using System.Linq;

public static class LongestSubsequenceFinder
{
    public static int FindLongestSubsequence(List<int> arr)
    {
        int n = arr.Count;
        int maxLength = 0;

        for (int i = 1; i < (1 << n); i++)
        {
            List<int> subsequence = new List<int>();
            for (int j = 0; j < n; j++)
            {
                if ((i & (1 << j)) > 0)
                {
                    subsequence.Add(arr[j]);
                }
            }

            subsequence.Sort();
            int diffSum = 0;
            for (int j = 1; j < subsequence.Count; j++)
            {
                diffSum += subsequence[j] - subsequence[j - 1];
            }

            if (diffSum % 2 == 0 && subsequence.Count > maxLength)
            {
                maxLength = subsequence.Count;
            }
        }

        return maxLength;
    }
}

// Krishna - TC UN