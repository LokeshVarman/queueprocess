using System;
using System.Diagnostics;

namespace addelement
{
    class addelement
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            Console.WriteLine("passing elements to be added from this process ............");
            p.StartInfo.FileName = "queue.exe";
            p.StartInfo.Arguments = "1 2 3 4 5 6";
            p.Start();
        }
    }
}
