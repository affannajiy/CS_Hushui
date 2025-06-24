//Clock 
function updateTime() {
    const now = new Date();
    const hours = now.getHours().toString().padStart(2, '0');
    const minutes = now.getMinutes().toString().padStart(2, '0');
    const seconds = now.getSeconds().toString().padStart(2, '0');

    //Format the time as HH:MM:SS
    const currentTime = `${hours}:${minutes}:${seconds}`;

    //Display the time inside the clock div
    //'clock' Id will match with the formatting above
    document.getElementById('clock').textContent = currentTime;
}

//Update the time every second
setInterval(updateTime, 1000);

//Call updateTime initially to show the time immediately on load
updateTime();