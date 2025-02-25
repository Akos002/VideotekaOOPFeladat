using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaOOP
{
    internal class Felhasznalo
    {
        public string Nev { get; set; }
        public List<Film> KolcsonzottFilmek { get; set; }

        public Felhasznalo(string nev)
        {
            this.Nev = nev;
            KolcsonzottFilmek = new List<Film>();
        }

        public bool Kolcsonoz(Film film)
        {

            if (KolcsonzottFilmek.Count >= 3)
            {
                Console.WriteLine("Maximum 3 film kölcsönözhető egyszerre.");
                return false;
            }
            else if (film.Kolcsonozve)
            {
                Console.WriteLine($"A(z) {film.Cim} című film ki van kölcsönözve.");
                return false;
            }
            else
            {
                film.Kolcsonzes();
                KolcsonzottFilmek.Add(film);
                Console.WriteLine($"A(z) {film.Cim} című film kikölcsönözve.");
                return true;
            }
        }

        public bool Visszaad(Film film)
        {
            if (!KolcsonzottFilmek.Contains(film))
            {
                Console.WriteLine("A film nincs kikölcsönözve.");
                return false;
            }
            else
            {
                film.Visszavetel();
                KolcsonzottFilmek.Remove(film);
                Console.WriteLine($"A(z) {film.Cim} visszavétele sikeres.");
                return true;
            }
        }

    }
}