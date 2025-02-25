using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaOOP
{
    internal class Videoteka
    {
        public List<Film> Filmek { get; private set; }
        public List<Felhasznalo> Felhasznalok { get; private set; }

        public Videoteka()
        {
            Filmek = new List<Film>();
            Felhasznalok = new List<Felhasznalo>();
        }

        public void FilmHozzaad(Film film)
        {
            Filmek.Add(film);
        }

        public void FelhasznaloHozzaad(Felhasznalo felhasznalo)
        {
            Felhasznalok.Add(felhasznalo);
        }

        public Film KeresFilm(string cim)
        {
            foreach (var film in Filmek)
            {
                if (film.Cim == cim)
                {
                    return film;
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
