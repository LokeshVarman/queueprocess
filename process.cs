using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace proces
{
    class Program
    {
        static void Main(string[] args)
        {
            create_process__A();
            create_process__B();
        }

        static void create_process__A()
        {
            
            Process p = new Process();
            p.StartInfo.FileName = "queue.exe";
            p.StartInfo.Arguments = "1 2 3 4 5 6";
            p.Start();
        }
        static void create_process__B()
        {
            Process p = new Process();
            p.StartInfo.FileName = "addelement.exe";
            //p.StartInfo.Arguments = "";
            p.Start();

        }
    }
}