using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace addelement
{
    class addelement
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            p.StartInfo.FileName = "queue.exe";
            p.StartInfo.Arguments = "1 2 3 4 5 6";
            p.Start();
        }
    }
}
