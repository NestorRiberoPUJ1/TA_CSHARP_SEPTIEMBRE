

var searchBtn = document.getElementById("searchBtn");
searchBtn.addEventListener("click", () => {
    let searchInputElement = document.getElementById("searchInputElement");
    let value = searchInputElement.value;
    alert("BUSCANDO " + value);
})


function destroy(element) {
    element.remove();
}



function like(element) {
    let num = element.nextElementSibling;
    let likes = parseInt(num.innerHTML);
    likes++;
    num.innerHTML = likes;
}