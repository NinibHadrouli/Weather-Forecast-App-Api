// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//var cardWeather = document.querySelector('#cardWeather').style.display = "none";
function updateStyleSheet() {
    const title = document.querySelector('#rubrik').style;
    
    const checkDark = document.querySelector('#checkDark');
    if (checkDark.checked) {
        document.body.style.backgroundColor = "#111";
        document.body.style.transition = "all 1s";
        title.color = "#80ced6";
    } else {
        document.body.style = "white";
        document.body.style.transition = "all 1s";
        title.color = "black";
    }
}

