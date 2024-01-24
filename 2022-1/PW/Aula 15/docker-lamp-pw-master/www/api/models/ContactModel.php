<?php

class ContactModel{

    var $Connection;

    function __construct(){
        require_once('db/ConnectClass.php');
        $connectClass = new ConnectClass();
        $connectClass -> openConnect();
        $this -> Connection = $connectClass -> getConn();
    }

    function listContacts(){
        $sql = 'SELECT * FROM contacts';
        return $this -> Connection -> query($sql);
    }

    function listContact($idContact){
        $sql = "SELECT * FROM contacts where idContact={$idContact}";
        return $this -> Connection -> query($sql);
    }

    function insertContact($contact){

        $sql = "
        INSERT INTO 
            contacts (name, email, message) 
        VALUES (
            '{$contact['name']}',
            '{$contact['email']}',
            '{$contact['message']}' 
            )
        ";
        
        return $this -> Connection -> query($sql);
    }

}


?>