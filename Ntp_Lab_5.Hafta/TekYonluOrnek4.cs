using System;

class Urun
{
    public string Ad { get; set; }
    private int Fiyat { get; set; }

    public Urun(string ad, int fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public int GetFiyat()
    {
        return Fiyat;
    }

    public string UrunBilgisi()
    {
        return "Ürün: " + Ad + ", Fiyat: " + GetFiyat() + " TL";
    }
}

class Siparis
{
    public DateTime Tarih { get; set; }
    public decimal Toplam { get; set; }

    public Siparis(DateTime tarih, decimal toplam)
    {
        Tarih = tarih;
        Toplam = toplam;
    }
}
