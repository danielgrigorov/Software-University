 function solution() {
    mainElement = document.getElementById('main');
    fetch('http://localhost:3030/jsonstore/advanced/articles/list')
    .then(res => res.json())
    .then(data =>
    data.forEach(x => {
        let wrapper = document.createElement('div');
        wrapper.classList.add('accordion')

        let headDiv = document.createElement('div');
        headDiv.classList.add('head')

        let span = document.createElement('span');
        span.textContent = x.title;
        let button = document.createElement('button');
        button.classList.add('button');
        button.id = x._id;
        button.textContent = 'More'

        headDiv.appendChild(span);
        headDiv.appendChild(button);

        let extraDiv = document.createElement('div');
        extraDiv.classList.add('extra')

        let pElement = document.createElement('p');
        fetch(`http://localhost:3030/jsonstore/advanced/articles/details/${x._id}`)
            .then(res2 => res2.json())
            .then(res2 => {
                pElement.textContent = res2.content;
            })

        extraDiv.appendChild(pElement);

        wrapper.appendChild(headDiv);
        wrapper.appendChild(extraDiv);

        mainElement.appendChild(wrapper);

        button.addEventListener('click', (e)=>{
            if (e.target.textContent === "More"){
                e.target.textContent = "Less";
                e.target.parentElement.nextElementSibling.style.display = 'block';
            } else {
                e.target.textContent = "More";
                e.target.parentElement.nextElementSibling.style.display = 'none';
            }
        })
    }))
}

solution();