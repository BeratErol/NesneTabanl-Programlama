using System;

class Siparis
{
    public DateTime Tarih { get; set; }
    public string Durum { get; set; }

    public Siparis(DateTime tarih, string durum)
    {
        Tarih = tarih;
        Durum = durum;
    }
}

class Müsteri
{
    public string Ad { get; set; }
    public string Telefon { get; set; }

    public Müsteri(string ad, string telefon)
    {
        Ad = ad;
        Telefon = telefon;
    }

    public void SiparisVer(Siparis siparis)
    {
        Console.WriteLine(Ad + " adlı müşteri " + siparis.Durum + " siparişi verdi.");
    }
}
