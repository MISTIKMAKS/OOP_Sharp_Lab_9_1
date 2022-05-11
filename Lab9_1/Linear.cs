using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    public class Linear : Root
    {
        private double result;

        public double A
        {
            get => a;
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException($"{nameof(value)} mustn't be 0!");
                }
            }
        }

        public double B
        {
            get => b;
            set { }
        }

        public Linear(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Result()
        {
            result = -(b/a);
            return result;
        }

        public override void Print()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Linear Result: ");
            Console.WriteLine(result);
            Console.WriteLine("-------------------------");
        }
    }
}
