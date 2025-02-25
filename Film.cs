using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaOOP
{
    internal class Film
    {
        public string Cim {  get; set; }
        public string Kategoria { get; set; }
        public int KiadasEv {  get; set; }
        public bool Kolcsonozve { get; private set; }

        public Film(string cim, string kategoria, int kiadasev)
        {
            this.Cim = cim;
            this.Kategoria = kategoria;
            this.KiadasEv = kiadasev;
        }

        public void Kolcsonzes ()
        {
            Kolcsonozve = true;
        }

        public void Visszavetel()
        {
            Kolcsonozve = false;
        }
    }
}
