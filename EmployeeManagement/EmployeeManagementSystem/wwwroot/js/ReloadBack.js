window.onload = function () {
    if (performance.navigation.type === 2) {
        document.body.style.visibility = "hidden";
        setTimeout(function () {
            location.replace(window.location.href);
        }, 10);
    }
};