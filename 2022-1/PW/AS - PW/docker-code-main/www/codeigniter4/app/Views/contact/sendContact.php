<h1>Contato</h1>
<form class="form" action="<?=base_url('/contactAction')?>" method="post">
    <div class="mb-3 mt-3 w-50">
        <label class="form-label">Nome</label>
        <input name="name" class="form-control" type="text">
    </div>
    <div class="mb-3 mt-3 w-50">
        <label class="form-label">E-mail</label>
        <input name="email" class="form-control" type="text">
    </div>
    <div class="mb-3 mt-3 w-50">
        <label class="form-label">Mensagem</label>
        <input name="message" class="form-control" type="text">
    </div>
     
    <input class="btn btn-primary mb-3" type="submit" value="Enviar">
</form>
