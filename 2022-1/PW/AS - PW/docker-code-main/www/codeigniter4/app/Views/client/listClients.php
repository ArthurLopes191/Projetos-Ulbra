<h1>Lista de Clientes</h1>

<table class="table">
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
        <td><a class="btn btn-primary" href="<?=base_url("client/{$client['idClient']}")?>">Detalhes</td>
        
        
    </tr>
    

    <?php
        }
    ?>
    
   
</table>