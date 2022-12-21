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
using System.Linq;
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
        public List<StavkaNarudzbe> listaStavkiNarudzbe = new List<StavkaNarudzbe>();


        internal void IspisNarudzbe()
        {
            Console.WriteLine("*-------------------------------------------------------*");

            Console.WriteLine("kupac: "+ Kupac.ImePrezime1);
            Console.Write("ID narudzbe:"+ OrderNo);
            Console.WriteLine("\t\tdatum: " + orderDate.ToString());
            Console.WriteLine("*-------------------------------------------------------*");
            Console.WriteLine("\t\tstavke narudzbe:");
            Console.WriteLine("*-------------------------------------------------------*");
            foreach (StavkaNarudzbe stavkaListeNarudzbe in listaStavkiNarudzbe)
            {
                Console.Write(stavkaListeNarudzbe.IDStavke1);
                Console.Write("\t");
                Console.Write(stavkaListeNarudzbe.NazivStavke1);
                Console.Write("\t");
                Console.Write(stavkaListeNarudzbe.KolicinaStavke1);
                Console.Write("\t");
                Console.Write(stavkaListeNarudzbe.CijenaStavke1);
                Console.Write("\n");

            };
            Console.WriteLine("*-------------------------------------------------------*");

        }

        internal void KreirajStavkuNarudzbe(int id, string naziv,  int koicina, decimal cijena)
        {
            Console.WriteLine("*-----------------------DEBUG --------------------------------*");
            stavkaNarudzbe.KreiraiStavku(id, naziv, koicina, cijena);
            Console.Write(stavkaNarudzbe.IDStavke1);
            Console.Write("\t");
            Console.Write(stavkaNarudzbe.NazivStavke1);
            Console.Write("\t");
            Console.Write(stavkaNarudzbe.KolicinaStavke1);
            Console.Write("\t");
            Console.Write(stavkaNarudzbe.CijenaStavke1);
            Console.Write("\n");

            listaStavkiNarudzbe.Add(stavkaNarudzbe);


        }
    }
}