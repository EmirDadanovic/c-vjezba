using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cjezbasharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pjesma pjesma1 = new Pjesma("loose yourself", "eminem",500);
            Pjesma pjesma2 = new Pjesma("unchained melody","righteous brothers",500);
            Console.WriteLine(pjesma2.Brojpjesama());
            Console.WriteLine(Pjesma.brojpjesama);
             Console.ReadLine();
        }

       
    }
}
