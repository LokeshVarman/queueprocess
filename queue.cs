
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QueueProcess
{
    class queueprocess
    {
        //public static string[] Params { get; set; }

        static void Main(string[] args)
        {
            int qsize = args.Length;
            //ParamHolder.Params = args;
            Queue Q = new Queue();
            for (int i = 0; i < qsize; i++)
            {
                Q.Enqueue(args[i]);
            }
            Console.WriteLine(" ELEMENTS IN THE QUEUE ARE:  ");
            foreach (var element in Q)
                Console.Write(element+"   "); 
            Console.WriteLine();
            Console.WriteLine("Size of Queue : "+ qsize);
            //Console.WriteLine(ParamHolder.Params[0]);
            //Console.WriteLine(ParamHolder.Params[1]);

            Console.ReadKey();
        }
    }
}

