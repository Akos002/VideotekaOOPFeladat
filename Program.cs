namespace goz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jatek jatek1 = new Jatek("The Witcher 3", "RPG", 12000);
            Jatek jatek2 = new Jatek("FIFA 23", "Sport", 18000);
            Jatek jatek3 = new Jatek("Cyberpunk 2077", "RPG", 15000);

            Felhasznalo adam = new Felhasznalo("Ádám", 20000);
            Jatekbolt jatekbolt = new Jatekbolt();

            jatekbolt.JatekHozzaad(jatek1);
            jatekbolt.JatekHozzaad(jatek2);
            jatekbolt.JatekHozzaad(jatek3);

            jatekbolt.JatekHozzaad(jatek3);
            Jatek witcher = jatekbolt.KeresJatek("The Witcher 3");
            adam.Vasarlas(witcher);
            

            adam.Feltoltes(10000);
            Jatek cyberpunk = jatekbolt.KeresJatek("Cyberpunk 2077");
            adam.Vasarlas(cyberpunk);

            adam.KonyvtarMegtekintes();
        }
    }
}