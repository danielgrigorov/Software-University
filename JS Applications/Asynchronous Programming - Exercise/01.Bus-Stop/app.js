async function getInfo() {
    let busStopInputElement = document.getElementById('stopId');
    let requestedBusStop = busStopInputElement.value;

    let stopNameElement = document.getElementById('stopName');
    let busesElement = document.getElementById('buses');

    let url = `http://localhost:3030/jsonstore/bus/businfo/${requestedBusStop}`;

    try {
        busesElement.innerHTML = '';

        const res = await fetch(url);
        const data = await res.json();
        busStopInputElement.value = '';

        stopNameElement.textContent = data.name;

        Object.entries(data.buses).forEach(x => {
            let busElement = document.createElement('li');
            busElement.textContent = `Bus ${x[0]} arrives in ${x[1]} minutes`
            busesElement.appendChild(busElement)
        })
    } catch (error) {
        stopNameElement.textContent = "Error";
    }
}