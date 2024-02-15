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
        processes.Sort((a, b) => a[0] - b[0]);
        PriorityQueue<int> heap = new PriorityQueue<int>();

        for (int i = 0; i < n; i++)
        {
            int s = processes[i][0];
            int e = processes[i][1];
            if (heap.Any() && heap.Peek() <= s)
            {
                heap.Dequeue();
            }
            heap.Enqueue(e);
        }

        return heap.Count;
    }
}

// krishna - TC_UK