using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksztalty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> ksztalty = new List<Ksztalt>();
            ksztalty.Add(new Czworokat(2,2,3,4));
            ksztalty.Add(new Czworokat(2, 2, 3,4));
            ksztalty.Add(new Czworokat(2, 2, 3,4));
            ksztalty.Add(new Czworokat(2, 2, 3,4));
            ksztalty.Add(new Czworokat(1, 2, 3,4));
            ksztalty.Add(new Czworokat(2, 23, 3,4));
            ksztalty.Add(new Czworokat(2, 21, 3,4));
            ksztalty.Add(new Czworokat(2, 5, 3,4));
            ksztalty.Add(new Czworokat(2, 3, 3,4));
            ksztalty.Add(new Czworokat(2, 8, 8,4));


            }

        }
    }
