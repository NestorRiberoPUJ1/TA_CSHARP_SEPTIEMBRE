/* Arreglos o listas */

var lista = [1, 14, 16, 28, 31, 44, 11, 31, 53, 47, 457, 234, 12, 7, 523, 754, 33, 454, 74,];

console.log(lista[5]);


console.log();
/* Básico */
for (let idx = 0; idx < lista.length; idx++) {
    console.log(lista[idx]);
}

console.log();
/* Directo */
for (const value in lista) {
    console.log(lista[value]);
}

console.log();
/* Metodos de arreglo */
lista.forEach((value) => {
    console.log(value);
})





function promedio(list) {
    let acumulador = 0;
    for (let index = 0; index < list.length; index++) {
        acumulador += list[index];
    }
    return acumulador / list.length;
}

function promedioDirecto(list) {
    let acumulador = 0;
    for (const index in list) {
        acumulador += list[index];
    }
    return acumulador / list.length;
}

function promedioMetodo(list) {
    const sum = list.reduce((total, value) => {
        return total + value;
    });
    return sum / list.length;
}
const inicio = performance.now();
console.log(promedio(lista));
const basico = performance.now();
console.log(promedioDirecto(lista));
const directo = performance.now();
console.log(promedioMetodo(lista));
const fin = performance.now();
console.log();
console.log("Basico", basico - inicio);
console.log("Directo", directo - basico);
console.log("Metodo", fin - directo);








/* Fibonacci */
/* 1,1,2,3,5,8,13,21,34,... */

function fiboBasic(serie) {
    const fibonacciArray = [0, 1];
    for (let idx = 0; idx < serie; idx++) {
        let actual = parseInt(fibonacciArray.slice(-1));
        let prev = parseInt(fibonacciArray.slice(-2));

        fibonacciArray.push(actual + prev);
    }
    return fibonacciArray;
}

console.log(fiboBasic(50));



