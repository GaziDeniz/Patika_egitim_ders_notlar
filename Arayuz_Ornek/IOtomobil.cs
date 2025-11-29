namespace Arayuz_Ornek
{
    public interface IOtomobil
    {
        int KacKapili();
        Marka MarkasiNe();  //Marka ismi yeni türetilmeyip belli bir listeden seçileceği için string yerine enum kullanmak daha mantıklı
        Renk RengiNe();     //renkler içinde aynı kural (üstteki) geçerli
    }
}