namespace Arayuz_Ornek
{
    public class Veyron : IOtomobil
    {
        public int KacKapili()
        {
            return 2;
        }

        public Marka MarkasiNe()
        {
            return Marka.Bugatti;
        }

        public Renk RengiNe()
        {
            return Renk.Pembe;
        }
    }
}