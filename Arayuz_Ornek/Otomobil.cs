namespace Arayuz_Ornek
{
    public abstract class Otomobil
    {
        public virtual int KacKapili()
        {
            return 2;                   //hepsi aynı olsaydı virtual kullanmaya gerek yoktu
        }

        public virtual Renk RengiNe()
        {
            return Renk.Siyah;
        }

        public abstract Marka MarkasiNe();  //hepsi farklı old. için return veya bi gövde olmayacak bu yüzden abstarct
    }
}