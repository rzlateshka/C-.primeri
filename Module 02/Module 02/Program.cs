using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Деклариране на променливи
            int a = 0, b = 0;
            int sum = 0;

            // Събиране на числа
            a = 50;
            b = 6;
            sum = a + b;

            //Писане в конзолата
            Console.Write(a);
            Console.Write(" + ");
            Console.Write(b);
            Console.Write(" = ");
            Console.WriteLine(sum);
            Console.ReadKey();
         }
    }
}
