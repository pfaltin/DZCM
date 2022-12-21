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
        private int IDStavke ;
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

        public int IDStavke1 { get => IDStavke; set => IDStavke = value; }
        public string NazivStavke1 { get => NazivStavke; set => NazivStavke = value; }
        public int KolicinaStavke1 { get => KolicinaStavke; set => KolicinaStavke = value; }
        public decimal CijenaStavke1 { get => CijenaStavke; set => CijenaStavke = value; }

        public void KreiraiStavku(int iDst, string nzStavke, int kolStavke, decimal ciStavke)
        {
            IDStavke = iDst;
            NazivStavke = nzStavke;
            KolicinaStavke = kolStavke;
            CijenaStavke = ciStavke;
        }


    }
}