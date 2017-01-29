using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
      class Czworokat : Ksztalt
    {                 
        public Czworokat()
        {
        }
        public Czworokat(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override double ObliczObwod()
        {
            return a+b+c+d;
        }
        public override double ObliczPole()
        {
            return Math.Sqrt(((1/2*(a+b+c+d)-a)*1/2*(a+b+c+d)-c)*1/2*((a+b+c+d)-c)*1/2*(a+b+c+d)-d);
        }
    }
}