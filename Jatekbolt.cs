using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goz
{
    internal class Jatekbolt
    {
        public List<Jatek> Jatekok { get; set; }
        public List<Felhasznalo> Felhasznalok { get; set; }

        public Jatekbolt()
        {
            Jatekok = new List<Jatek>();
            Felhasznalok = new List<Felhasznalo>();
        }

        public void JatekHozzaad(Jatek jatek)
        {
            Jatekok.Add(jatek);
        }

        public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
        {
            Felhasznalok.Add(felhasznalo);
        }

        public Jatek KeresJatek(string cim)
        {
            foreach (var jatek in Jatekok)
            {
                if (jatek.Cim == cim)
                {
                    return jatek;
                }
            }
            return null;
        }

        public Felhasznalo Keresfelhasznalo(string nev)
        {
            foreach (var felhasznalo in Felhasznalok)
            {
                if (felhasznalo.Nev == nev)
                {
                    return felhasznalo;
                }
            }
            return null;
        }
    }
}
