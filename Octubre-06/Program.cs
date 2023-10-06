// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
    JS no es fuertemente tipado
    var nombre="Nestor";
    let apellido ="Ribero";
    nombre=12.4;

    C#  fuertemente tipado
    string nombre="Nestor";
    
    int -> numero entero
    float -> numero con decimal
    char -> caracter
    string -> cadena de caracteres
    bool -> binarias 1/0
    double -> numeros 
 */




short inventario = 18;

if (inventario < 20)
{
    Console.WriteLine("Hay que comprar más");
}
else if (inventario < 25)
{
    Console.WriteLine("Se está acabando");
}
else
{
    Console.WriteLine("Hay suficiente");
}

/**/

Console.WriteLine("Fin del programa");




/* BUCLES SON procesos iterativos  */


/**/


for (int idx = 10; idx < 20; idx++)
{
Console.WriteLine(idx);
}
Console.WriteLine("---------------");
Random rand = new Random();

short num = (short)rand.Next(0, 10);
Console.WriteLine(num);
while (num != 5)
{
    
    num = (short)rand.Next(0, 10);
    Console.WriteLine(num);
}