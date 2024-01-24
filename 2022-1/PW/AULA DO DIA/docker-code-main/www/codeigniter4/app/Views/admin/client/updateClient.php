<h1>Alterando Cliente</h1>
<form class="form" action="<?=base_url("admin/client/updateAction/{$client['idClient']}")?>" method="post" enctype='multipart/form-data'>
    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Nome</label>
        <input name='name' class="form-control" type="text" value="<?=$client['name']?>">
    </div>  
    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Email</label>
        <input name='email' class="form-control" type="email" value="<?=$client['email']?>">
    </div>
    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Telefone</label>
        <input name='phone' class="form-control" type="text" value="<?=$client['phone']?>">
    </div>   
    <div class="mb-3 mt-3 w-25">
        <label class="form-label">Endereço</label>
        <input name='address' class="form-control" type="text" value="<?=$client['address']?>">
    </div>

    <input class="btn btn-primary mb-3" type="submit" value="Enviar">
</form>
