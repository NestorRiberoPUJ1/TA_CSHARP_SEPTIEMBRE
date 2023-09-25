

/* Funciones */

function producto(n1, n2) {
    return n1 * n2;
}

const product = (n1, n2) => n1 * n2;

var init = performance.now();
producto(4, 8);
var step = performance.now();
product(4, 8);
var end = performance.now();
var step2;


console.log("Tradicional", step - init);
console.log("Flecha", end - step);




/* Recorridos de arreglos */

function randomArray(size) {
    const arr = [];

    for (let idx = 0; idx < size; idx++) {
        arr.push(Math.round(Math.random() * 100));
    }
    return arr;
}



const myArray = randomArray(10);
console.log(myArray);

const doubleArray = (arr) => {
    for (const idx in arr) {
        arr[idx] = arr[idx] * 2;
    }
    return arr;
}

const duplica = (arr) => {
    arr.forEach((value, idx) => { arr[idx] = value * 2 });
    return arr;
}

init = performance.now();
doubleArray([...myArray]);
step = performance.now();
duplica([...myArray]);
step2 = performance.now();
myArray.map((value) => value * 2);
end = performance.now();


console.log("Tradicional", step - init);
console.log("Flecha", step2 - step);
console.log("Directo", end - step2);




/* 
    Dado el arreglo ["Perro","Gato","Vaca","Alpaca","Chinchilla"]
    convertirlo en éste: ["Vaca","Alpaca","Chinchilla","Perro","Gato"]
    recorrer 23401
 */



let array1 = ["Perro", "Gato", "Vaca", "Alpaca", "Chinchilla"];
let temp = 0, j = 2, temp2 = 0;

for (let i = 0; i < array1.length; i++) {
    if (i < 3) {
        temp = array1[i];
        temp2 = array1[j];
        array1[j] = temp;
        array1[i] = temp2;
        j--;
    }
}

console.log("Mauricio", array1);

let arreglo = ["Perro", "Gato", "Vaca", "Alpaca", "Chinchilla"];
let longitudDelArreglo = arreglo.length;

for (let x = 0; x < longitudDelArreglo / 2; x++) {
    let temporal = arreglo[x];
    let indiceContrario = longitudDelArreglo - x - 1;
    arreglo[x] = arreglo[indiceContrario];
    arreglo[indiceContrario] = temporal;
}
console.log("Andres", arreglo);

let array = ["Perro", "Gato", "Vaca", "Alpaca", "Chinchilla"];
let arrayAux = [];
let arrayAux2 = [];
let arrayFinal = [];
for (let i = 2; i < array.length; i++) {
    arrayAux[i - 2] = array[i];
}

for (i = 0; i < 2; i++) {
    arrayAux2[i] = array[i];
}

arrayFinal = arrayAux.concat(arrayAux2);

console.log("Rafael", arrayFinal);




let arrayTest = ["Perro", "Gato", "Vaca", "Alpaca", "Chinchilla"];
arrayTest.push(arrayTest.shift());
arrayTest.push(arrayTest.shift());
console.log(arrayTest);


















