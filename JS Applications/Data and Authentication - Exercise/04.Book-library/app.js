let loadBooksButton = document.getElementById('loadBooks')
let table = document.querySelector('tbody')
let form = document.querySelector('form')
let h3 = document.querySelector('h3')
let submitButton = document.querySelector('form button')
let bookName = document.querySelector('input[name = "title"]')
let authorName = document.querySelector('input[name = "author"]')

let idToEdit;

let baseUrl = 'http://localhost:3030/jsonstore/collections/books'

const loadBooks = () => {
    table.innerHTML = ''
    fetch(baseUrl)
        .then(res => res.json())
        .then(data => {
            Object.entries(data).forEach(x => {
                let tr = document.createElement('tr')
                let tdTitle = document.createElement('td')
                let tdAuthor = document.createElement('td')
                let tdAction = document.createElement('td')
                let editButton = document.createElement('button')
                let deleteButton = document.createElement('button')

                tdTitle.textContent = x[1].title
                tdAuthor.textContent = x[1].author

                tr.setAttribute("id", x[0])

                editButton.textContent = "Edit"
                deleteButton.textContent = "Delete"

                tdAction.appendChild(editButton)
                tdAction.appendChild(deleteButton)

                tr.appendChild(tdTitle)
                tr.appendChild(tdAuthor)
                tr.appendChild(tdAction)

                table.appendChild(tr)

                editButton.addEventListener('click', editBook)

                deleteButton.addEventListener('click', deleteBook)
            })
        })
}

const editBook = (e) => {

    submitButton.textContent = "Save"
    h3.textContent = "Edit FORM"

    let titleToChange = e.target.parentElement.parentElement.children[0]
    let authorToChange = e.target.parentElement.parentElement.children[1]

    idToEdit = e.target.parentElement.parentElement.id;

    authorName.value = authorToChange.textContent
    bookName.value = titleToChange.textContent
}

const submitBook = (e) => {
    e.preventDefault()

    if (submitButton.textContent === "Submit") {

        let author = authorName.value
        let title = bookName.value

        if (author !== '' && title !== '') {

            fetch(baseUrl, {
                method: "POST",
                headers: {
                    "content-type": "application/json"
                },
                body: JSON.stringify({
                    author,
                    title
                })
            })

            bookName.value = ''
            authorName.value = ''
        }

    } else {
        fetch(`${baseUrl}/${idToEdit}`, {
            method: "PUT",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                author: authorName.value,
                title: bookName.value
            })
        })

        authorName.value = ''
        bookName.value = ''

        h3.textContent = "FORM"
        submitButton.textContent = "Submit"
    }

    loadBooks()

}

const deleteBook = (e) => {
    let idToDelete = e.target.parentElement.parentElement.id
    table.removeChild(e.target.parentElement.parentElement)

    fetch(`${baseUrl}/${idToDelete}`,{
        method: "DELETE"
    })

    loadBooks()
}

loadBooksButton.addEventListener('click', loadBooks)

submitButton.addEventListener('click', submitBook)