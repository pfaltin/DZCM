using zadatak20221219;

namespace zadatak20221219
{
    internal class Kupac
    {
        private int IDKupca;
        private string ImePrezime;
        private string Adresa;
        private string Telefon;

        public Kupac(int IDKupca, string ImePrezime, string Adresa, string Telefon)
        {
            this.IDKupca = IDKupca;
            this.ImePrezime = ImePrezime;
            this.Adresa = Adresa;
            this.Telefon = Telefon;
        }


    void IspisPodatakaKupca() 
        {
            Console.WriteLine("Kupac je :" );
            Console.WriteLine(ImePrezime); Console.WriteLine(Adresa); Console.WriteLine(Telefon);

        }

    }
}



//  public Kupac
//    IDKupca(int, private) 
//	    ImePrezime(string, private) 
//	    Adresa(string, private) 
//	    Telefon(int, private) 
// 	
//	    IspisPodatakaKupca(void, public) 