using System;
using System.Collections.Generic;

class Oda
{
    public string Boyut { get; set; }
    public string Tip { get; set; }

    public Oda(string boyut, string tip)
    {
        Boyut = boyut;
        Tip = tip;
    }
}

class Ev
{
    public string Ad { get; set; }
    public List<Oda> Odalar { get; set; }

    public Ev(string ad)
    {
        Ad = ad;
        Odalar = new List<Oda>();
    }

    public void OdaEkle(Oda oda)
    {
        Odalar.Add(oda);
    }
}
