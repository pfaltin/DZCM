/*
 * public Narudzba

    BrojNarudzbe(int, private) 
	Kupac(Kupac. public) 
    DatumNarudzbe(DateTime. private) 
	StavkeNarudzbe(List<StavkaNarudzbe>, private) 

	KreirajStavkuNarudzbe(void, public) 
	Ukupno(decimal, public) 
	IspisNarudzbe(void, public) 
*/
using zadatak20221219;
namespace zadatak20221219
{
    internal class Narudzba
    {
        public Narudzba(int BrojNarudzbe, DateTime DatumNarudzbe)
        {
            OrderNo = BrojNarudzbe;
            orderDate = DatumNarudzbe;
        }

        public int OrderNo { get; }
        public DateTime orderDate { get; }
        public Kupac Kupac { get; internal set; }

        StavkaNarudzbe stavkaNarudzbe = new StavkaNarudzbe();
        private List<StavkaNarudzbe> stavkeNarudzbe = new List<StavkaNarudzbe>();


        internal void IspisNarudzbe()

        {
            Console.WriteLine("kupac: "+ Kupac);
            Console.WriteLine("ID :"+ OrderNo);
            Console.WriteLine("datum: " + orderDate.ToString());
            Console.WriteLine("stavke narudzbe:");

            foreach(StavkaNarudzbe stavkaListeNarudzbe in stavkeNarudzbe)
            {
                Console.WriteLine(stavkaListeNarudzbe.IDStavke1);
                Console.WriteLine(stavkaListeNarudzbe.NazivStavke1);
                Console.WriteLine(stavkaListeNarudzbe.KolicinaStavke1);
                Console.WriteLine(stavkaListeNarudzbe.CijenaStavke1);
            }

        }

        internal void KreirajStavkuNarudzbe(int id, string naziv,  int koicina, decimal cijena)
        {
            
            stavkaNarudzbe.KreiraiStavku(id, naziv, koicina, cijena);
            stavkeNarudzbe.Add(stavkaNarudzbe);

        }
    }
}