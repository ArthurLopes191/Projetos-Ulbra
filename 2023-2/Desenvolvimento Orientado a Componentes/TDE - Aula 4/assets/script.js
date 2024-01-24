function ready(){
    home()
    document.getElementById("home").addEventListener("click", home)
    document.getElementById("sobre").addEventListener("click", sobre)
    document.getElementById("contato").addEventListener("click", contato)
}


function home(){
    const section = document.getElementById("sessao")
    section.innerHTML = `
        <h1 class="m-3"> HOME </h1>
    `
}

function sobre(){
    const section = document.getElementById("sessao")
    section.innerHTML = `
        <h1 class="m-3"> SOBRE </h1>
    `
}

function contato(){
    const section = document.getElementById("sessao")
    section.innerHTML = `
    <form action="/action_page.php">
    <div class="form-group col-md-4">
      <label>Nome:</label>
      <input type="text" class="form-control" placeholder="Nome" id="nome">
    </div>
    <div class="form-group col-md-4">
      <label>Email:</label>
      <input type="email" class="form-control" placeholder="Email" id="email">
    </div>

    <div class="form-group col-md-4">
      <label>Telefone:</label>
      <input type="tel" class="form-control" placeholder="Telefone" id="telefone">
    </div>
    
    <div class="form-group form-check">
      
    </div>
    <button type="button" class="btn btn-primary m-3" id="submitButton">Submit</button>
  </form>
    `

    const button = document.getElementById("submitButton").addEventListener("click", submitForm)
}


function submitForm(){
    const nome = document.getElementById("nome")
    const email = document.getElementById("email")
    const telefone = document.getElementById("telefone")

    const contato = {nome: nome.value, email: email.value, telefone: telefone.value}

    const section = document.getElementById("sessao")
    section.innerHTML = `
    <table class="table">
        <thead>
        <tr>
            <th>Nome: ${contato.nome}</th>
        </tr>
        <tr>        
            <th>Email: ${contato.email}</th>
        </tr>
        <tr>
            <th>Telefon: ${contato.telefone}</th>
        </tr>
        </thead>
    </table>
    `
}