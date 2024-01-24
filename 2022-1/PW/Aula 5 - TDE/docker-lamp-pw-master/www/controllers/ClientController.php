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
            'password' => $_POST['password'],
            'sexo' => $_POST['sexo'],
            'checkbox[]' => $_POST['checkbox[]'],
            'message' => $_POST['message'],
            'select' => $_POST['select']
    
        );

        require_once('views/templates/header.php');
        require_once('views/client/insertClientAction.php');
        require_once('views/templates/footer.php');
    }
}



?>