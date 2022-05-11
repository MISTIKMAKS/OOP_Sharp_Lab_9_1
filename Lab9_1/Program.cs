using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear:");
            Root line = new Linear(2, 3);
            Console.WriteLine(line.Result());
            line.Print();

            Console.WriteLine("");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("");

            Console.WriteLine("Square:");
            Root square = new Square(9, -12, -5);
            Console.WriteLine(Math.Round(square.Result_A(), 2));
            Console.WriteLine(Math.Round(square.Result_B(), 2));
            square.Print();

            Console.ReadKey();
        }
    }
}
