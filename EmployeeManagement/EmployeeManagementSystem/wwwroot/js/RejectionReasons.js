document.addEventListener("DOMContentLoaded", function () {
    let openFormButton = document.getElementById("openForm");
    let formModal = document.getElementById("formModal");
    let closeButton = document.querySelector(".close");
    let pageContent = document.getElementById("pageContent");

    if (openFormButton && formModal) {
        openFormButton.addEventListener("click", function (event) {
            event.preventDefault(); 
            formModal.style.display = "flex";
            pageContent.classList.add("blurred");
        });
    }

    if (closeButton && formModal) {
        closeButton.addEventListener("click", function () {
            formModal.style.display = "none";
            pageContent.classList.remove("blurred");
        });
    }

    window.addEventListener("click", function (e) {
        if (e.target === formModal) {
            formModal.style.display = "none";
            pageContent.classList.remove("blurred");
        }
    });
});