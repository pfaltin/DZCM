using zadatak20221219;

namespace zadatak20221219
{
    internal class Kupac
    {
        private int IDKupca;
        private string ImePrezime;
        private string Adresa;
        private string Telefon;

        public Kupac(int iDKupca, string imePrezime, string adresa, string telefon)
        {
            this.IDKupca = iDKupca;
            this.ImePrezime = imePrezime;
            this.Adresa = adresa;
            this.Telefon = telefon;
        }

        public int IDKupca1 { get => IDKupca; set => IDKupca = value; }
        public string ImePrezime1 { get => ImePrezime; set => ImePrezime = value; }
        public string Adresa1 { get => Adresa; set => Adresa = value; }
        public string Telefon1 { get => Telefon; set => Telefon = value; }

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