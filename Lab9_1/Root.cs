using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    public abstract class Root
    {
        public double a;
        public double b;

        public virtual double Result() 
        {
            return 0;
        }

        public virtual double Result_A()
        {
            return 0;
        }

        public virtual double Result_B()
        {
            return 0;
        }

        public virtual void Print() 
        { 

        }
    }
}
