function solve() {
    let departButton = document.getElementById('depart')
    let arriveButton = document.getElementById('arrive')
    let infoElementsList = document.getElementsByClassName('info')
    let infoElement = infoElementsList[0]
    let start = 'depot';
    let currentStop = 'depot'

    async function depart() {
        try {
            departButton.disabled = true;
            let url = `http://localhost:3030/jsonstore/bus/schedule/${start}`
            arriveButton.disabled = false;
            let res = await fetch(url);
            let data = await res.json();
            currentStop = data.name;
            start = data.next;
            infoElement.textContent = `Next stop ${data.name}`
        } catch (error) {
            departButton.disabled = true;
            arriveButton.disabled = true;
            infoElement.textContent = 'Error'
        }
    }

    async function arrive() {
        departButton.disabled = false;
        arriveButton.disabled = true;
        infoElement.textContent = `Arriving at ${currentStop}`
    }

    return {
        depart,
        arrive
    };
}

let result = solve();