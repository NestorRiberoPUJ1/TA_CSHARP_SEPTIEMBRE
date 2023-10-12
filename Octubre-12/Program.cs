// See https://aka.ms/new-console-template for more information


Deportivo portofino = new Deportivo("Ford", "Mustang", true, "Rear");
portofino.ShowInfo();
/* Console.WriteLine(portofino.Cilindraje);
Console.WriteLine(portofino.Powertrain);
Console.WriteLine(portofino.Modelo); */

Formula1 rb18b = new Formula1("RedBull", "RB18B", true, 1.4);
rb18b.ShowInfo();
/* Console.WriteLine(rb18b.Marca);
Console.WriteLine(rb18b.Powertrain);
Console.WriteLine(rb18b.DRS);
Console.WriteLine(rb18b.Cilindraje); */

public class Auto
{
    public string Marca;
    public string Modelo;
    public bool Automatico;
    protected double Cilindraje;
    public Auto(string marca, string modelo, bool automatico, double cilindraje)
    {
        Marca = marca;
        Modelo = modelo;
        Automatico = automatico;
        Cilindraje = cilindraje;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"---------------------");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Automatico: {Automatico}");
        Console.WriteLine($"Cilindraje: {Cilindraje}");
    }
}

public class Deportivo : Auto
{
    public string Powertrain;
    // Notice the lack of fields
    // We use "base" to refer to the constructor from Animal we're using to create this Cat
    // and filling in the parameters we would expect for a basic Cat
    public Deportivo(string marca, string modelo, bool automatico, string powertrain) : base(marca, modelo, true, 5.0)
    {
        Powertrain = powertrain;
    }
}

public class Formula1 : Deportivo
{
    public bool DRS;
    public Formula1(string marca, string modelo, bool drs, double cilindraje) : base(marca, modelo, false, "Rear")
    {
        DRS = drs;
        Cilindraje = cilindraje;
    }


    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"DRS: {DRS}");
        Console.WriteLine($"Powertrain: {Powertrain}");
    }

}