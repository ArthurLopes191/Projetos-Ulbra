<?php

class ClientController{
    function insertClient(){
        require_once('views/templates/header.php');
        require_once('views/client/insertClient.php');
        require_once('views/templates/footer.php');
    }

    function insertClientAction(){

        $client = array(
            'name' => $_POST['name'],
            'phone' => $_POST['phone'],
            'email' => $_POST['email'],
            'address' => $_POST['address']
        );

        require_once('views/templates/header.php');
        require_once('views/client/insertClientAction.php');
        require_once('views/templates/footer.php');
    }
}



?>