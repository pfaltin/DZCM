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

        private List<StavkaNarudzbe> stavkaNarudzbe = new List<StavkaNarudzbe>();

        internal void IspisNarudzbe()
        {

        }

        internal void KreirajStavkuNarudzbe(int v1, string v2, int v3, decimal v4)
        {
            StavkaNarudzbe stavkaNarudzbe = new StavkaNarudzbe();

        }
    }
}