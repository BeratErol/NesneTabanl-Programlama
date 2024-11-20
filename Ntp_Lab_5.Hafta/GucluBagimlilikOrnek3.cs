using System;

class Motor
{
    public int Guc { get; set; }
    public string Tip { get; set; }

    public Motor(int guc, string tip)
    {
        Guc = guc;
        Tip = tip;
    }

    public void MotorBilgisi()
    {
        Console.WriteLine("Motor Gücü: " + Guc + " HP, Tip: " + Tip);
    }
}

class Otomobil
{
    public string Marka { get; set; }
    public Motor Motor { get; set; }

    public Otomobil(string marka)
    {
        Marka = marka;
        MotorOlustur();
    }

    public void MotorOlustur()
    {
        Motor = new Motor(150, "Benzinli");
    }
}
