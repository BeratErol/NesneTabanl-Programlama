using System;
using System.Collections.Generic;

class Kitap
{
    public string Baslik { get; set; }
    public string Yazar { get; set; }

    public Kitap(string baslik, string yazar)
    {
        Baslik = baslik;
        Yazar = yazar;
    }
}

class Kutuphane
{
    public string Ad { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Kutuphane(string ad)
    {
        Ad = ad;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
}