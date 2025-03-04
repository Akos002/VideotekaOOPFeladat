namespace goz
{
    internal class Felhasznalo
    {
        public string Nev { get; set; }
        public int Egyenleg { get; set; }
        public List<Jatek> Konyvtar { get; set; }

        public Felhasznalo(string nev, int egyenleg)
        {
            this.Nev = nev;
            Konyvtar = new List<Jatek>();
            Egyenleg = egyenleg;
        }

        public bool Vasarlas(Jatek jatek)
        {
            if (Konyvtar.Any(i => i.Cim == jatek.Cim))
            {
                Console.WriteLine("A játék már a könyvtáradban van!");
                return false;
            }
            else if (Egyenleg < jatek.Ar)
            {
                Console.WriteLine($"A(z) {jatek.Cim} című játék megvásárlásához nincs elég pénzed!");
                return false;
            }
            else
            {
                Egyenleg -= jatek.Ar;
                Konyvtar.Add(jatek);
                Console.WriteLine($"A(z) {jatek.Cim} című játék megvásárlása sikeres.");
                return true;
            }
        }

        public void KonyvtarMegtekintes()
        {
            Console.WriteLine("Megvásárolt játékok:");
            foreach (var jatek in Konyvtar)
            {
                Console.WriteLine($"- {jatek.Cim}");
            }
        }

        public void Feltoltes(int osszeg)
        {
            Egyenleg += osszeg;
            Console.WriteLine($"Egyenleg feltöltve: +{osszeg} Ft");
        }
    }
}
