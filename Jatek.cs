using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goz
{
    internal class Jatek
    {
        public string Cim { get; set; }
        public string Kategoria { get; set; }
        public int Ar { get; set; }

        public Jatek(string cim, string kategoria, int ar)
        {
            Cim = cim;
            Kategoria = kategoria;
            Ar = ar;
        }
    }
}
