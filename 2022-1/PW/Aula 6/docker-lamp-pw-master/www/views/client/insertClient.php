<h1>Inserindo Cliente</h1>
<form class="form" action="?controller=client&action=insertClientAction" method="post">
    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Nome</label>
        <input name='name' class="form-control" type="text">
    </div>  
    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Senha</label>
        <input name='password' class="form-control" type="password">
    </div>   

    <div class="mb-3 mt-3 "> 
        <input class="form-check-input" type="radio" name='sexo' id="sexom">
        <label class="form-check-label"  value="Masculino" >Masculino</label>

        <input class="form-check-input" type="radio" name='sexo'>
        <label class="form-check-label" value="Feminino">Feminino</label>
    </div>

    <div class="mb-3 mt-3 ">
        <label class="form-label">Opção 1</label>
        <input name='op1' value="Opção 1" type="checkbox">
    </div> 
    <div class="mb-3 mt-3 ">
        <label class="form-label">Opção 2</label>
        <input name='op2' value="Opção 2" type="checkbox">
    </div> 

    <div class="mb-3 mt-3 ">
        <label class="form-label">Opção 3</label>
        <input name='op3' value="Opção 3" type="checkbox">
    </div> 

    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Texto:</label>   
        <textarea name='message' class="form-control rounded-0" rows="3"></textarea>
    </div> 

    <select name='select' class="mb-3 mt-3 form-select w-25" >
        <option selected disabled>Select</option>
        <option value="Opção 1">Um</option>
        <option value="Opção 2">Dois</option>
        <option value="Opção 3">Tres</option>
    </select>


    <input class="btn btn-primary mb-3" type="submit" value="Enviar">
</form>
