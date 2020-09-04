using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = "abc\ndef";
            string[] j = k.Split('\n');
            Console.WriteLine(j[0]);
            



            Console.ReadKey();
        }
    }
}
