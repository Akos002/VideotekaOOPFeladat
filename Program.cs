namespace VideotekaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film1 = new Film("Titanic", "Elérhető", 1997);
            Film film2 = new Film("Inception", "Elérhető", 2010);
            Film film3 = new Film("Interstellar", "Elérhető", 2014);
            Film film4 = new Film("Avatar 2", "Elérhető", 2022);

            Felhasznalo anna = new Felhasznalo("Anna");
            Videoteka videoteka = new Videoteka();

            videoteka.FelhasznaloHozzaad(anna);
            videoteka.FilmHozzaad(film1);
            videoteka.FilmHozzaad(film2);
            videoteka.FilmHozzaad(film3);

            anna.Kolcsonoz(videoteka.KeresFilm("Titanic"));
            anna.Kolcsonoz(videoteka.KeresFilm("Interstellar"));
            Film joker = videoteka.KeresFilm("Joker");

            if (joker != null)
            {
                anna.Kolcsonoz(joker);
            }
            else
            {
                Console.WriteLine("Ez a film nem szerepel a listában");
            }

            anna.Kolcsonoz(videoteka.KeresFilm("Inception"));
            anna.Kolcsonoz(videoteka.KeresFilm("Avatar 2"));
            anna.Visszaad(film1);

        }
    }
}