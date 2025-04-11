const openFormButton = document.getElementById("openForm");
const formModal = document.getElementById("formModal");
const closeButton = document.querySelector(".close");
const pageContent = document.getElementById("pageContent");

openFormButton.addEventListener("click", function () {
  formModal.style.display = "flex";
  pageContent.classList.add("blurred");
});

closeButton.addEventListener("click", function () {
  formModal.style.display = "none";
  pageContent.classList.remove("blurred");
});

window.addEventListener("click", function (e) {
  if (e.target === formModal) {
    formModal.style.display = "none";
    pageContent.classList.remove("blurred");
  }
});
