namespace Arayuz_Ornek
{
    public class Avendator : IOtomobil
    {
        public int KacKapili()
        {
            return 2;
        }

        public Marka MarkasiNe()
        {
            return Marka.Lamborgini;
        }

        public Renk RengiNe()
        {
            return Renk.Turkuvaz;
        }
    }
}