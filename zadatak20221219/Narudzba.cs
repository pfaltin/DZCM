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
        public Narudzba(int v, DateTime now)
        {
            V = v;
            Now = now;
        }

        public int V { get; }
        public DateTime Now { get; }
        public Kupac Kupac { get; internal set; }

        internal void IspisNarudzbe()
        {
            throw new NotImplementedException();
        }

        internal void KreirajStavkuNarudzbe(int v1, string v2, int v3, decimal v4)
        {
            StavkaNarudzbe stavkaNarudzbe = new StavkaNarudzbe();

        }
    }
}