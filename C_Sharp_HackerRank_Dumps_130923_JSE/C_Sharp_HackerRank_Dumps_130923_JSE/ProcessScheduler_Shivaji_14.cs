using System;
using System.Collections.Generic;
using System.Linq;

public class ProcessScheduler
{
    public static int GetMinCores(List<int> start, List<int> end)
    {
        int n = start.Count;
        List<int[]> processes = new List<int[]>();
        for (int i = 0; i < n; i++)
        {
            processes.Add(new int[] { start[i], end[i] });
        }
        processes = processes.OrderBy(a => a[0]).ToList();
        PriorityQueue<int> heap = new PriorityQueue<int>();

        for (int i = 0; i < n; i++)
        {
            int s = processes[i][0];
            int e = processes[i][1];
            if (heap.Count > 0 && heap.Peek() <= s)
            {
                heap.Poll();
            }
            heap.Offer(e);
        }

        return heap.Count;
    }

    public static void Main(string[] args)
    {
        List<int> start = new List<int> { 1, 3, 4 };
        List<int> end = new List<int> { 3, 5, 6 };
        Console.WriteLine(GetMinCores(start, end));
    }
}

// Shivaji - 14TC Passed.
