

/* Son modificables y se pueden crear con o sin valor */
var nombre = "Nestor";
let apellido;
console.log(apellido);
nombre = "Nestor Eduardo";
apellido = "Ribero Vargas"



/* No son modificables y no se pueden crear sin valor */
const rh = "A+";

console.log("Hola Mundo");


var edad = 20;

if (edad > 21) {
    console.log("Puede comprar Ron");
}
else if (edad > 18) {
    console.log("Puede comprar Cerveza");
}
else if (edad > 15) {
    console.log("Puede comprar gaseosa");
}
else {
    console.log("No puede comprar licor");
}

var animal = "pollo";

switch (animal) {
    case "perro":
        console.log("WOW");
        break;
    case "vaca":
        console.log("moo");
        break;
    case "gato":
        console.log("miau");
        break;
    case "chinchilla":
        console.log("pspsps");
        break;

    default:
        console.log("kikiriki");
        break;
}

/* Variables primitivas */
var num = 26;
var text = "texto24";
var logicas = false;


/* Variables no primitivas */
var lista = ["Grupo Firme", "Grupo Frontera", "Grupo Niche"];

var contacto = {
    nombre: "Nestor",
    edad: 26,
    titulo: "Ingeniero Electrónico",
    graduado: true,
}



