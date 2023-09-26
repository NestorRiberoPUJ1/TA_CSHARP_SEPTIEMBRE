

const newImg = () => {
    console.log("Buscando Perrito");
    const init = performance.now();
    fetch("https://dog.ceo/api/breeds/image/random", {
        method: 'GET',
    })
        .then((response) => response.json())
        .then((result) => {
            let img = document.getElementById("dogPicture");
            console.log(result.message);
            img.src = result.message;
            const end = performance.now();

            console.log("ELAPSED TIME:", end - init);
        })
        .catch(error => console.log('error', error));
}


async function loadBreeds() {

    try {

        const response = await fetch("https://dog.ceo/api/breeds/list/all", {
            method: 'GET',
        });
        console.log(response);
        const result = await response.json();
        console.log(result);
        const breeds = Object.keys(result.message);
        console.log(breeds);

        const selectBreed = document.getElementById("selectBreed");

        for (const idx in breeds) {
            selectBreed.innerHTML += `<option value="${breeds[idx]}" >${breeds[idx].toUpperCase()}</option>`
        }
    } catch (error) {
        console.log(error);
    }

}

const searchDogBreed = async () => {
    const breed = document.getElementById("selectBreed").value;
    console.log(breed);
    try {

        const response = await fetch(`https://dog.ceo/api/breed/${breed}/images/random`, {
            method: 'GET',
        });
        const result = await response.json();
        let img = document.getElementById("dogPicture");
        img.src = result.message;
    } catch (error) {
        console.log(error);
    }

}


loadBreeds();