let submitBtn = document.getElementById('submit')

let firstName = document.querySelector("[name = 'firstName']")
let lastName = document.querySelector("[name = 'lastName']")
let facultyNumber = document.querySelector("[name = 'facultyNumber']")
let grade = document.querySelector("[name = 'grade']")

let table = document.querySelector('#results tbody')

let baseUrl = 'http://localhost:3030/jsonstore/collections/students'

const loadInfoAction = () => {
    table.innerHTML = ''
    fetch(baseUrl)
        .then(res => res.json())
        .then(data => Object.values(data))
        .then(data => data.forEach(x => {
            let trElement = document.createElement('tr')
            table.appendChild(trElement)

            let tdFirstName = document.createElement('td')
            let tdLastName = document.createElement('td')
            let tdFacultyNumber = document.createElement('td')
            let tdGrade = document.createElement('td')

            tdFirstName.textContent = `${x.firstName}`
            tdLastName.textContent = `${x.lastName}`
            tdFacultyNumber.textContent = `${x.facultyNumber}`
            tdGrade.textContent = `${Number(x.grade).toFixed(2)}`

            trElement.appendChild(tdFirstName)
            trElement.appendChild(tdLastName)
            trElement.appendChild(tdFacultyNumber)
            trElement.appendChild(tdGrade)
        }))
}

const submitAction = (e) => {
    e.preventDefault()

    if (firstName.value !== '' && lastName.value !== '' && facultyNumber.value !== '' && grade.value !== '' && grade.value >= 2.00 && grade.value <= 6.00) {

        fetch(baseUrl, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                'firstName': firstName.value,
                'lastName': lastName.value,
                'facultyNumber': facultyNumber.value,
                'grade': grade.value,
            })
        })

        let trElement = document.createElement('tr')
        table.appendChild(trElement)

        let tdFirstName = document.createElement('td')
        let tdLastName = document.createElement('td')
        let tdFacultyNumber = document.createElement('td')
        let tdGrade = document.createElement('td')

        tdFirstName.textContent = `${firstName.value}`
        tdLastName.textContent = `${lastName.value}`
        tdFacultyNumber.textContent = `${facultyNumber.value}`
        tdGrade.textContent = `${Number(grade.value).toFixed(2)}`

        trElement.appendChild(tdFirstName)
        trElement.appendChild(tdLastName)
        trElement.appendChild(tdFacultyNumber)
        trElement.appendChild(tdGrade)

        firstName.value = '';
        lastName.value = '';
        facultyNumber.value = '';
        grade.value = '';
    }
}

submitBtn.addEventListener('click', submitAction)
window.addEventListener('load', loadInfoAction)