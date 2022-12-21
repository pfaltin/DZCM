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
        private List<StavkaNarudzbe> listaStavkeNarudzbe = new List<StavkaNarudzbe>();


        internal void IspisNarudzbe()

        {
            Console.WriteLine("kupac: "+ Kupac.ImePrezime1);
            Console.WriteLine("ID narudzbe:"+ OrderNo);
            Console.WriteLine("datum: " + orderDate.ToString());
            Console.WriteLine("stavke narudzbe:");

            foreach(StavkaNarudzbe stavkaListeNarudzbe in listaStavkeNarudzbe)
            {
                Console.Write(stavkaListeNarudzbe.IDStavke1);
                Console.Write("\t");
                Console.Write(stavkaListeNarudzbe.NazivStavke1);
                Console.Write("\t");
                Console.Write(stavkaListeNarudzbe.KolicinaStavke1);
                Console.Write("\t");
                Console.Write(stavkaListeNarudzbe.CijenaStavke1);
                Console.Write("\n");
                
            }

        }

        internal void KreirajStavkuNarudzbe(int id, string naziv,  int koicina, decimal cijena)
        {
            
            stavkaNarudzbe.KreiraiStavku(id, naziv, koicina, cijena);
            listaStavkeNarudzbe.Add(stavkaNarudzbe);

        }
    }
}