namespace Arayuz_Ornek
{
    public class Mustang : IOtomobil
    {
        public int KacKapili()
        {
            return 2;
        }

        public Marka MarkasiNe()
        {
            return Marka.Ford;
        }

        public Renk RengiNe()
        {
            return Renk.Yeşil;
        }
    }
}