async function attachEvents() {
    let input = document.getElementById('location');
    let submitButton = document.getElementById('submit');
    let forecastDiv = document.getElementById('forecast');
    let currentDiv = document.getElementById('current');
    let upcomingDiv = document.getElementById('upcoming');
    let labelDiv = document.getElementsByClassName('label');
    let index;
    let code;

    let forecastsDiv = document.createElement('div');

    let forecastInfoDiv = document.createElement('div');

    let weatherSigns = {
        "Sunny": "\u2600",
        "Partly sunny": "⛅",
        "Overcast": "\u2601",
        "Rain": "\u2614",
    }

    let getWeather = async () => {

        try {
            let result = await fetch('http://localhost:3030/jsonstore/forecaster/locations')
            let data = await result.json()
            index = data.find(x => x.name === input.value)
            code = index.code

            let result2 = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${code}`)
            let currentCondition = await result2.json()

            let result3 = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${code}`)
            let futureCondition = await result3.json()

            forecastsDiv.classList.add('forecasts')
            currentDiv.appendChild(forecastsDiv)

            forecastsDiv.innerHTML = '';

            let conditionSybmolSpan = document.createElement('span');
            conditionSybmolSpan.className = 'condition symbol'
            conditionSybmolSpan.textContent = weatherSigns[currentCondition.forecast.condition]
            forecastsDiv.appendChild(conditionSybmolSpan)

            let conditionSpan = document.createElement('span');
            conditionSpan.classList.add('condition');
            forecastsDiv.appendChild(conditionSpan);

            let forecastDataName = document.createElement('span');
            forecastDataName.classList.add('forecast-data');
            forecastDataName.textContent = currentCondition.name;
            conditionSpan.appendChild(forecastDataName);

            let forecastDataDegrees = document.createElement('span');
            forecastDataDegrees.classList.add('forecast-data');
            forecastDataDegrees.textContent = `${currentCondition.forecast.low}°/${currentCondition.forecast.high}°`
            conditionSpan.appendChild(forecastDataDegrees);

            let forecastDataCondition = document.createElement('span');
            forecastDataCondition.classList.add('forecast-data');
            forecastDataCondition.textContent = currentCondition.forecast.condition;
            conditionSpan.appendChild(forecastDataCondition);

            forecastInfoDiv.classList.add('forecast-info');
            upcomingDiv.appendChild(forecastInfoDiv);

            forecastInfoDiv.innerHTML = '';

            let upcomingSpan = document.createElement('span');
            upcomingSpan.classList.add('upcoming');
            forecastInfoDiv.appendChild(upcomingSpan);

            let upcomingSymbolSpan = document.createElement('span');
            upcomingSymbolSpan.classList.add('symbol');
            upcomingSymbolSpan.textContent = weatherSigns[futureCondition.forecast[0].condition];
            upcomingSpan.appendChild(upcomingSymbolSpan);

            let upcomingForeCastDataDegrees = document.createElement('span');
            upcomingForeCastDataDegrees.classList.add('forecast-data');
            upcomingForeCastDataDegrees.textContent = `${futureCondition.forecast[0].low}°/${futureCondition.forecast[0].high}°`
            upcomingSpan.appendChild(upcomingForeCastDataDegrees)

            let upcomingForeCastDataCondition = document.createElement('span');
            upcomingForeCastDataCondition.classList.add('forecast-data');
            upcomingForeCastDataCondition.textContent = futureCondition.forecast[0].condition;
            upcomingSpan.appendChild(upcomingForeCastDataCondition);

            // second day

            let upcomingSpan2 = document.createElement('span');
            upcomingSpan2.classList.add('upcoming');
            forecastInfoDiv.appendChild(upcomingSpan2);

            let upcomingSymbolSpan2 = document.createElement('span');
            upcomingSymbolSpan2.classList.add('symbol');
            upcomingSymbolSpan2.textContent = weatherSigns[futureCondition.forecast[1].condition];
            upcomingSpan2.appendChild(upcomingSymbolSpan2);

            let upcomingForeCastDataDegrees2 = document.createElement('span');
            upcomingForeCastDataDegrees2.classList.add('forecast-data');
            upcomingForeCastDataDegrees2.textContent = `${futureCondition.forecast[1].low}°/${futureCondition.forecast[1].high}°`
            upcomingSpan2.appendChild(upcomingForeCastDataDegrees2)

            let upcomingForeCastDataCondition2 = document.createElement('span');
            upcomingForeCastDataCondition2.classList.add('forecast-data');
            upcomingForeCastDataCondition2.textContent = futureCondition.forecast[1].condition;
            upcomingSpan2.appendChild(upcomingForeCastDataCondition2);

            // third day

            let upcomingSpan3 = document.createElement('span');
            upcomingSpan3.classList.add('upcoming');
            forecastInfoDiv.appendChild(upcomingSpan3);

            let upcomingSymbolSpan3 = document.createElement('span');
            upcomingSymbolSpan3.classList.add('symbol');
            upcomingSymbolSpan3.textContent = weatherSigns[futureCondition.forecast[2].condition];
            upcomingSpan3.appendChild(upcomingSymbolSpan3);

            let upcomingForeCastDataDegrees3 = document.createElement('span');
            upcomingForeCastDataDegrees3.classList.add('forecast-data');
            upcomingForeCastDataDegrees3.textContent = `${futureCondition.forecast[2].low}°/${futureCondition.forecast[2].high}°`
            upcomingSpan3.appendChild(upcomingForeCastDataDegrees3)

            let upcomingForeCastDataCondition3 = document.createElement('span');
            upcomingForeCastDataCondition3.classList.add('forecast-data');
            upcomingForeCastDataCondition3.textContent = futureCondition.forecast[2].condition;
            upcomingSpan3.appendChild(upcomingForeCastDataCondition3);

            forecastDiv.style.display = 'block'
        } catch (error) {
            // forecastDiv.textContent = "Error"
            forecastDiv.style.display = 'block'
        }
    }

    submitButton.addEventListener('click', getWeather)

}

attachEvents();