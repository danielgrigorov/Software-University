function attachEvents() {
    let textArea = document.getElementById('messages');
    let submitButton = document.getElementById('submit');
    let refreshButton = document.getElementById('refresh');

    let authorsList = document.getElementsByName('author');
    let contentsList = document.getElementsByName('content')

    let author = authorsList[0];
    let content = contentsList[0];

    const refreshHandler = () => {
        fetch('http://localhost:3030/jsonstore/messenger')
            .then(res => res.json())
            .then(data => Object.values(data))
            .then(data2 => textArea.textContent = data2.map(x => `${x.author}: ${x.content}`).join('\n'))
    }

    const submitHandler = () => {
        if (!author.value || !content.value) {
            throw new Error("All fields are required!")
        }
        
        fetch('http://localhost:3030/jsonstore/messenger', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                'author': author.value,
                'content': content.value,
            }),
        })
        .then(data => data.json())

        author.value = '';
        content.value = '';
    }

    submitButton.addEventListener('click', submitHandler);
    refreshButton.addEventListener('click', refreshHandler);
}

attachEvents();