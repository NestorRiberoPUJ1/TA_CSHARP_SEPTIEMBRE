


console.log("LOADED JS");



var countriesContainer = document.getElementById("countriesContainer");

var requestOptions = {
    method: 'GET',
    redirect: 'follow'
};

const getCountry = async () => {
    const response = await fetch("http://localhost:5214/Country/any", requestOptions);
    const result = await response.json();
    console.log(result);

    countriesContainer.innerHTML += `
    <div>
        <h1>${result.name}</h1>
        <h1>#${result.id}</h1>
        <img src="${result.image}" alt="flag" height="200px">
    </div>
    <hr>
    `;
}

getCountry();