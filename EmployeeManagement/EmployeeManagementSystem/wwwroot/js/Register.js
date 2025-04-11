const clickableImage = document.getElementById('clickableImage');
const fileInput = document.getElementById('fileInput');

clickableImage.addEventListener('click', () => {
    fileInput.click();
});

fileInput.addEventListener('change', (event) => {
    const file = event.target.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = (e) => {
            clickableImage.src = e.target.result;
        };
        reader.readAsDataURL(file);
    }
});