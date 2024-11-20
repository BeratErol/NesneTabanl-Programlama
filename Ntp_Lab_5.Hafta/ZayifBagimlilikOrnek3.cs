using System;
using System.Collections.Generic;

class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }

    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }
}

class Sirket
{
    public string Ad { get; set; }
    public List<Calisan> Calisanlar { get; set; }

    public Sirket(string ad)
    {
        Ad = ad;
        Calisanlar = new List<Calisan>();
    }

    public void CalisanEkle(Calisan calisan)
    {
        Calisanlar.Add(calisan);
    }
}
