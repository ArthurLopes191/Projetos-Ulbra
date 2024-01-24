<h1>Lista de Clientes</h1>

<table class="table">
    <tr>
        
        <th>Nome</th>
        <th>Telefone</th>
        <th>Email</th>
        <th colspan="3">Ações</th>
        
    </tr>
    
    <?php
        foreach($clients as $client){
    ?>

    <tr>
        
        <td><?=$client['name']?></td>
        <td><?=$client['phone']?></td>
        <td><?=$client['email']?></td>
        <td><a class="btn btn-primary" href="<?=base_url("admin/client/{$client['idClient']}")?>">Detalhes</td>
        <td><a class="btn btn-warning" href="<?=base_url("admin/client/update/{$client['idClient']}")?>">Alterar</td>
        <td><a class="btn btn-danger" href="<?=base_url("admin/client/delete/{$client['idClient']}")?>">Deletar</td>
        
    </tr>
    

    <?php
        }
    ?>
    
   
</table>