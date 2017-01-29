using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    class TrojkatProstokatny : Trojkat
    {
        public TrojkatProstokatny()
        {
        }
        public TrojkatProstokatny(double e, double c)
        {
        e = a;
        e = b;
        c = Math.Sqrt(a * a + b * b);
        }
    }
}
