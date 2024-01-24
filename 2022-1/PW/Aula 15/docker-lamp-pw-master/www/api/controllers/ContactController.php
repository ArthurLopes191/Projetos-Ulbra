<?php

class ContactController{

    var $ContactModel;

    function __construct(){
        //if(!isset($_SESSION['user'])){
        //    header('Location: index.php?controller=main&action=login');       
        //}
        require_once('models/ContactModel.php');
        $this -> ContactModel = new ContactModel();
    }

    function listContacts(){
        $result = $this -> ContactModel -> listContacts();
        $arrayContacts = array();
        while($line = $result -> fetch_assoc()){
            array_push($arrayContacts, $line);

        }
        header('Content-Type: appication/json');
        echo (json_encode($arrayContacts));
    }

    function listContact($idContact){
        $result = $this -> ContactModel -> listContact($idContact);
        if($contact = $result -> fetch_assoc()){
            header('Content-Type: appication/json');
            echo (json_encode($contact));
        }else{
            header('Content-Type: appication/json');
            echo('{"error": 01 , "message": "Contato não encontrado"}');
        }
    }


    function insertContact(){

        $contact = json_decode(file_get_contents('php://input'));

        $arrayContact = array(
            'name' => $contact -> name,
            'email' => $contact -> email,
            'message' => $contact -> message
            
        
        );
        $idContact = $this -> ContactModel -> insertContact($arrayContact);
        header('Content-Type: appication/json');
        echo('{"cod": 01 , "message": "Contato foi cadastrado"}');
    }
}

?>