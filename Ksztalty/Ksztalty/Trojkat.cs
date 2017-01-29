using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    class Trojkat : Ksztalt
    {
      public Trojkat()
        {
        }
      public Trojkat(double a, double b, double c)
      {
          this.a = a;
          this.b = b;
          this.c = c;
      }
         public override double ObliczObwod()
      {
          return a + b + c; 
      }
         public override double ObliczPole()
         {
             return Math.Sqrt((1 / 2 * (a + b + c) - a) * 1 / 2 * (a + b + c) - b) * 1 / 2 * ((a + b + c) - c);
         }
    }
}
