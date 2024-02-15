using System;
using System.Collections.Generic;

public class ProcessScheduling
{
    public static int GetMinCores(List<int> start, List<int> end)
    {
        int n = start.Count;
        if (n <= 1)
            return 1;

        start.Sort();
        end.Sort();

        int coresNeeded = 1;
        int maxCores = 1;
        int i = 1;
        int j = 0;

        while (i < n && j < n)
        {
            if (start[i] <= end[j])
            {
                coresNeeded++;
                i++;
                if (coresNeeded > maxCores)
                    maxCores = coresNeeded;
            }
            else
            {
                coresNeeded--;
                j++;
            }
        }

        return maxCores;
    }

    public static void Main(string[] args)
    {
        List<int> start = new List<int> { 1, 3, 4 };
        List<int> end = new List<int> { 3, 5, 6 };
        int minCores = GetMinCores(start, end);
        Console.WriteLine("Minimum number of cores required: " + minCores);
    }
}

// Zarrish -100 % Running.