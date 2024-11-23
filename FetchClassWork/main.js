fetch("https://dummyjson.com/products")
.then(response => {
    if (!response.ok) {
      throw new Error('Error');
    }
    return response.json();
  })
  .then(Data => {
   console.log(Data)
    const maindiv = document.getElementById("MainDiv")
    let example;

    Data.products.forEach(element => {
        example+=
        `
        <div class="card" style="width: 18rem;" >
  <img src="${element.thumbnail}" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">${element.title}</h5>
    <p class="card-text">${element.description}</p>
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item">Category : ${element.category}</li>
    <li class="list-group-item">Brand : ${element.brand}</li>
    <li class="list-group-item">Rating : ${element.rating}</li>
  </ul>
  <div class="card-body">
    <a href="#" class="card-link">Card link</a>
    <a href="#" class="card-link">Another link</a>
  </div>
</div>
        
        
        `
    });

    maindiv.innerHTML=example
  })