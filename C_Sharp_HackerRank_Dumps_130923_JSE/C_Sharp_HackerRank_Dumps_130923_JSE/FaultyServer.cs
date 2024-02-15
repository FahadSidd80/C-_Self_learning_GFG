using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Faulty Server -- All TC Passing - 100%  

public static int countFaults(int n, List<string> logs)
{
    Dictionary<string, int> errorCount = new Dictionary<string, int>();
    int replacements = 0;

    foreach (string log in logs)
    {
        string[] parts = log.Split(' ');// space between single quotes
        string serverId = parts[0];
        string status = parts[1];

        if (status == "error")
        {
            if (errorCount.ContainsKey(serverId))
            {
                int count = errorCount[serverId];
                count++;
                errorCount[serverId] = count;

                if (count == 3)
                {
                    replacements++;
                    errorCount[serverId] = 0;
                }
            }
            else
            {
                errorCount[serverId] = 1;
            }

        }
        else
        {
            errorCount[serverId] = 0;
        }
    }
    return replacements;
}


