function attachEvents() {
    let loadButton = document.getElementById('btnLoad')
    let createButton = document.getElementById('btnCreate')
    let phoneBookUlElement = document.getElementById('phonebook')
    let personElement = document.getElementById('person')
    let phoneElement = document.getElementById('phone')
    let baseUrl = 'http://localhost:3030/jsonstore/phonebook'
    const loadHandler = () => {
        phoneBookUlElement.innerHTML = '';
        fetch(baseUrl)
            .then(res => res.json())
            .then(data => Object.values(data))
            .then(dataArray =>
                dataArray.forEach(x => {
                    let liElement = document.createElement('li')
                    let deleteButtonElement = document.createElement('button')
                    deleteButtonElement.textContent = "Delete"
                    liElement.setAttribute("id", x._id)
                    liElement.textContent = `${x.person}: ${x.phone}`
                    liElement.appendChild(deleteButtonElement)
                    phoneBookUlElement.appendChild(liElement)
                    const deleteHandler = (e) => {
                       let currentId = e.target.parentElement.id
                        phoneBookUlElement.removeChild(e.target.parentElement)
                        fetch(`${baseUrl}/${currentId}`,{
                            method: "DELETE"
                        })
                        .then(res => res.json())
                    }
                    deleteButtonElement.addEventListener('click', deleteHandler)
                })
            )
    }
    const createHandler = () => {
        if (personElement.value !== '' && phoneElement.value !== '') {
            fetch(baseUrl, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    'person': personElement.value,
                    'phone': phoneElement.value
                })
            })
            personElement.value = ''
            phoneElement.value = ''
            loadButton.click()
        }
    }
    loadButton.addEventListener('click', loadHandler)
    createButton.addEventListener('click', createHandler)
}
attachEvents();