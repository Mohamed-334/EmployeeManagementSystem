const openFormButton = document.getElementById("openForm_AddUser");
const formModal = document.getElementById("formModal_AddUser");
const closeButton = document.getElementById("close_AddUser");
const profileImage = document.getElementById("profileImage_AddUser");
const uploadImage = document.getElementById("uploadImage_AddUser");
const extraFields = document.getElementById("extraFields_AddUser");

openFormButton.addEventListener("click", function () {
  formModal.style.display = "flex";
});

closeButton.addEventListener("click", function () {
  formModal.style.display = "none";
});

window.addEventListener("click", function (e) {
  if (e.target === formModal) {
    formModal.style.display = "none";
  }
});
uploadImage.addEventListener("change", function (e) {
  const file = e.target.files[0];
  if (file) {
    const reader = new FileReader();
    reader.onload = function (event) {
      profileImage.src = event.target.result;
    };
    reader.readAsDataURL(file);
  }
});