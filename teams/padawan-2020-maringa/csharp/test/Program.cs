using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var alergia = new Allergies(128);
            alergia.Alergias = alergia.List();
            Console.WriteLine(alergia.Alergias);

            Console.ReadKey();
        }
    }
}
