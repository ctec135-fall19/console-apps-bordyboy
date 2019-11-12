using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //In class demo
            if (args.Length == 0) Console.WriteLine("You do not have any arguments");
            else
            {
                foreach(string s in args)
                {
                    Console.WriteLine(s);
                }
            }
            //Console.WriteLine(args.Length);
        }
    }
}
