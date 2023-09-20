
var terms = document.querySelector(".terms > button");

var movieContainer = document.getElementsByClassName("movieContainer")[0];

console.log(terms);
console.log(movieContainer);

function cerrarTerminos() {
    let backdrop = document.getElementById("backdropScreen");
    backdrop.remove();
}


terms.addEventListener("click", () => {
    console.log("ACEPTADOS");
    cerrarTerminos();
})


function cerrar() {
    console.log("CERRRANDO");
    cerrarTerminos();
}




var movies = Array.from(document.querySelectorAll(".movie"));

console.log(movies);
for (let idx = 0; idx < movies.length; idx++) {

    const movie = movies[idx];
    console.log(movie);
    if (movie) {
        const playBtn = movie.querySelector(".playBtn");
        if (playBtn) {
            playBtn.addEventListener("click", () => {
                alert("Clicked Play");
            })
        }
    }

}



var element = `
<div class="movie">
<img src="https://www.themoviedb.org/t/p/original/h5J4W4veyxMXDMjeNxZI46TsHOb.jpg" alt="Forrest">
<div class="sideContent">
    <h3>Forrest Gump </h3>
    <div>
        <button class="roundIconBtn solidBtn">
            <img src="./assets/play_arrow.svg" alt="play">
        </button>
        <button class="roundIconBtn outlineBtn">
            <img src="./assets/expand_more.svg" alt="expand_more">
        </button>
    </div>
</div>

</div>`

movieContainer.innerHTML += element;