document.getElementById("attendanceForm").addEventListener("submit", function(event) {
    event.preventDefault();

    // Get form data
    const employeeName = document.getElementById("employeeName").value;
    const status = document.getElementById("status").value;

    if (employeeName && status) {
        // Create a new table row for the attendance record
        const table = document.getElementById("attendanceTable").getElementsByTagName('tbody')[0];
        const newRow = table.insertRow();

        const nameCell = newRow.insertCell(0);
        const statusCell = newRow.insertCell(1);
        const dateCell = newRow.insertCell(2);

        nameCell.textContent = employeeName;
        statusCell.textContent = status;
        dateCell.textContent = new Date().toLocaleDateString();

        // Style the status dynamically
        if (status === "Present") {
            statusCell.style.color = "#4CAF50"; // Green
        } else if (status === "Absent") {
            statusCell.style.color = "#F44336"; // Red
        } else {
            statusCell.style.color = "#FF9800"; // Orange
        }

        // Clear the form fields
        document.getElementById("employeeName").value = "";
        document.getElementById("status").value = "";
    } else {
        alert("Please fill in all fields.");
    }
});
