namespace zadatak20221219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak za klase i modifikatore – 19-12-2022");
            // Primjer programskog koda u nastavku će vam poslužiti za testiranje rada aplikacije

            Kupac mico = new Kupac(11, "Mićo Programerić", "Markov Put 2", "8335362662");
            Narudzba nova_narudzba = new Narudzba(1, DateTime.Now);
            nova_narudzba.Kupac = mico;
            nova_narudzba.KreirajStavkuNarudzbe(111, "Banane", 3, 24.66M);
            nova_narudzba.KreirajStavkuNarudzbe(112, "Čokolada", 13, 224.66M);
            nova_narudzba.KreirajStavkuNarudzbe(113, "Pivo", 23, 124.66M);
            nova_narudzba.IspisNarudzbe();

        }
    }
}