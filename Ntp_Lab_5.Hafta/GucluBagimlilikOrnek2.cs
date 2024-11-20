using System;

class Islemci
{
    public int Cekirdekler { get; set; }
    public int Frekans { get; set; }

    public Islemci(int cekirdekler, int frekans)
    {
        Cekirdekler = cekirdekler;
        Frekans = frekans;
    }

    public void IslemciBilgisi()
    {
        Console.WriteLine("Çekirdek Sayısı: " + Cekirdekler + ", Frekans: " + Frekans + " MHz");
    }
}

class Bilgisayar
{
    public string Model { get; set; }
    public Islemci Islemci { get; set; }

    public Bilgisayar(string model)
    {
        Model = model;
        IslemciOlustur();
    }

    public void IslemciOlustur()
    {
        Islemci = new Islemci(4, 3200);
    }
}
