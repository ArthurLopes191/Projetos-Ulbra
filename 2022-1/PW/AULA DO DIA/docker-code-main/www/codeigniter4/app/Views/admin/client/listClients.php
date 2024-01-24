<h1>Lista de Clientes</h1>

<table class="table">

    <form class="form" action="<?=base_url('admin/searchClient')?>" method="post">
            <div class="row">
                <div class="col-md-3 mb-3">
                    <input name='search' class="form-control" type="text" placeholder="Pesquisar por...">
                </div>
                <div class="col-md-2 mb-3">
                    <input class="btn btn-primary" type="submit" value="Pesquisar">
                </div> 
            </div>
    </form>

    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Telefone</th>
        <th>Email</th>
        <th>Endereço</th>
        <th colspan="3">Ações</th>
        
    </tr>
    
    <?php
        foreach($clients as $client){
    ?>

    <tr>

        <td><?=$client['idClient']?></td>
        <td><?=$client['name']?></td>
        <td><?=$client['phone']?></td>
        <td><?=$client['email']?></td>
        <td><?=$client['address']?></td>
        <td><a class="btn btn-primary" href="<?=base_url("admin/client/{$client['idClient']}")?>">Detalhes</td>
        <td><a class="btn btn-warning" href="<?=base_url("admin/client/update/{$client['idClient']}")?>">Alterar</td>
        <td><a class="btn btn-danger" href="<?=base_url("admin/client/delete/{$client['idClient']}")?>">Deletar</td>
        
    </tr>
    

    <?php
        }
    ?>
    
   
</table>