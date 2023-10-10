// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



/*Array*/

/*Estructurar*/
/* string contacto1 = "Nestor";
string contacto2 = "Max";
string contacto3 = "Sergio";
string contacto4 = "Pierre";
string contacto5 = "Esteban";
string contacto6 = "Nico"; */


/*Inicio con tamaño fijo sin valores*/
string[] contactos = new string[10];
Console.WriteLine(contactos[2]);
contactos[5] = "MAX";

/*Inicio con contenido*/
string[] contacts = { "Nestor", "Max", "Sergio" };
Console.WriteLine(contacts[2]);

string[] people;
people = new string[] { "Nestor", "Max", "Sergio" };
Console.WriteLine(people[2]);


short[] edades = { 1, 22, 48, 12, 15 };



/*Iteradores para arreglos */

/*Iterador clasico*/
for (int idx = 0; idx < edades.Length; idx++)
{
    Console.WriteLine(edades[idx]);
}

/*iterador directo*/
foreach (short edad in edades)
{
    Console.WriteLine($"I am {edad} years old");
}




Console.WriteLine("----------------------------");
/*LISTAS*/

List<string> perritos = new List<string>();
/* Console.WriteLine(perritos[2]); */

perritos.Add("pluto");
perritos.Add("snoppy");
perritos.Add("tintin");
perritos.Add("firulais");
perritos.Add("tintin");
perritos.Add("ayudante de santa");
perritos.Add("tintin");
Console.WriteLine(perritos[2]);

/*ITERAR LISTAS*/

/*convencional*/
for (int idx = 0; idx < perritos.Count; idx++)
{
    Console.WriteLine("-" + perritos[idx]);
}

/*insercion de dato en posicion específica*/
perritos.Insert(2, "tom");

/*remoción por valor*/
perritos.Remove("tintin");


/*remocion en posición especifica*/
perritos.RemoveAt(3);

/*Directa */
foreach (string perro in perritos)
{
    Console.WriteLine($"Hola soy {perro}");
}

Dictionary<string, bool> animales = new Dictionary<string, bool>();


animales.Add("Tigre", false);
animales.Add("Coyote", false);
animales.Add("Perro", true);
animales.Add("Vaca", true);
animales.Add("Gato", true);


Console.WriteLine("Vaca es domestica:" + animales["Vaca"]);


/*ITERAR*/

/*Tipado de tipo de dato*/
foreach (KeyValuePair<string, bool> entrada in animales)
{
    Console.WriteLine(entrada.Key + " - " + entrada.Value);
}


/*Sin tipado de tipo de dato*/
foreach (var entrada in animales)
{
    Console.WriteLine(entrada.Key + " - " + entrada.Value);
}