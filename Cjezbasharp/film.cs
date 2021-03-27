using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cjezbasharp
{
    class Pjesma {
        public string ime;
        public string pjevac;
        public int duzina;
        public static int brojpjesama;

        public Pjesma(string aime, string apjevac, int aduzina) 
        {
            ime = aime;
            pjevac = apjevac;
            duzina = aduzina;
            brojpjesama++;  
        }
        public int Brojpjesama() {
            return brojpjesama;
        }
    }
        
}
    


