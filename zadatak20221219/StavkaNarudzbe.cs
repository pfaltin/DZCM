//public StavkaNarudzbe 
//	IDStavke (int, private) 
//	NazivStavke (string, private) 
//	KolicinaStavke (int, private) 
//	CijenaStavke (decimal, private) 
	
//	KreiraiStavku(StavkaNarudzbe, public) 
//	Ukupno(decimal, public) 
//	IspisStavke(void, public) 



namespace zadatak20221219
{
    internal class StavkaNarudzbe
    {
        private int IDStavke;
        private string NazivStavke;
        private int KolicinaStavke;
        private decimal CijenaStavke;

        public StavkaNarudzbe()
        {
        }

        public StavkaNarudzbe(int iDStavke, string nazivStavke, int kolicinaStavke, decimal cijenaStavke)
        {
            IDStavke = iDStavke;
            NazivStavke = nazivStavke;
            KolicinaStavke = kolicinaStavke;
            CijenaStavke = cijenaStavke;
        }
    }
}