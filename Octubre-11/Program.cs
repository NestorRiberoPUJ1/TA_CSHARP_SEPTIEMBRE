// See https://aka.ms/new-console-template for more information

Automovil Q3 = new Automovil(4, 4, 1.8, "premium", "audi", "q3", true);
Automovil Q5 = new Automovil(4, 4, 2.0, "premium", "audi", "q5", true);
Console.WriteLine(Q3.getRuedas());
Q3.setRuedas(5);
Console.WriteLine(Q3.getRuedas());

Q3.agotarTanque();

Automovil.sonidoDeCarro();

Console.WriteLine(Automovil.NumAutos);
Console.WriteLine(Q3._Automatico);
Console.WriteLine(Q3._Automatico = false);
Console.WriteLine(Q3._Automatico);
class Automovil
{
    public static short NumAutos = 0;
    /*Atributos de la clase*/
    short Ruedas;
    short Puertas;
    double Cilindraje;
    string Combustible;
    string Marca;
    string Modelo;
    private bool Automatico;
    public bool _Automatico
    {
        get { return Automatico; }
        set { Automatico = value; }
    }
    /* Constructor */

    public Automovil(short ruedas, short puertas, double cilindraje, string combustible, string marca, string modelo, bool automatico)
    {
        Ruedas = ruedas;
        Puertas = puertas;
        Cilindraje = cilindraje;
        Combustible = combustible;
        Marca = marca;
        Modelo = modelo;
        Automatico = automatico;
        NumAutos++;
    }

    public short getRuedas()
    {
        return Ruedas;
    }
    public void setRuedas(short ruedas)
    {
        Ruedas = ruedas;
    }

    public void agotarTanque()
    {
        Console.WriteLine("TANQUE VACIO");
    }

    public static void sonidoDeCarro()
    {
        Console.WriteLine("RMMMMM");
    }





}
