window.onscroll = function () {countOffset()};

var navbar = document.getElementById("myNavbar");
var sticky = navbar.offsetTop;

function countOffset() {
    if (window.pageYOffset + 30 >= sticky) {
        navbar.classList.add("sticky")
    } else {
        navbar.classList.remove("sticky");
    }
}

function showSmallMenu() {
    var x = document.getElementById("myNavbar");
    if (x.className === "topnav") {
        x.className += " responsive";
    } else {
        x.className = "topnav";
    }
} 