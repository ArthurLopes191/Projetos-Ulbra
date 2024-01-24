<?php

class ClientController{

    var $ClientModel;

    function __construct(){
        //if(!isset($_SESSION['user'])){
        //    header('Location: index.php?controller=main&action=login');       
        //}
        require_once('models/ClientModel.php');
        $this -> ClientModel = new ClientModel();
    }

    function listClients(){
        $result = $this -> ClientModel -> listClients();
        $arrayClients = array();
        while($line = $result -> fetch_assoc()){
            array_push($arrayClients, $line);

        }
        header('Content-Type: appication/json');
        echo (json_encode($arrayClients));
    }

    function listClient($idClient){
        $result = $this -> ClientModel -> listClient($idClient);
        if($client = $result -> fetch_assoc()){
            header('Content-Type: appication/json');
            echo (json_encode($client));
        }else{
            header('Content-Type: appication/json');
            echo('{"error": 01 , "message": "Cliente não encontrado"}');
        }
    }


    function insertClient(){

        $client = json_decode(file_get_contents('php://input'));

        $arrayClient = array(
            'name' => $client -> name,
            'email' => $client -> email,
            'phone' => $client -> phone,
            'address' => $client -> address
        
        );
        $idClient = $this -> ClientModel -> insertClient($arrayClient);
        header('Content-Type: appication/json');
        echo('{"cod": 01 , "message": "Cliente foi cadastrado"}');
    }



    function updateClient($idClient){

        $client = json_decode(file_get_contents('php://input'));

        $arrayClient = array(
            'idClient' => $idClient,
            'name' => $client -> name,
            'email' => $client -> email,
            'phone' => $client -> phone,
            'address' => $client -> address
        
        );
        $this -> ClientModel -> updateClient($arrayClient);
    }

    function deleteClient($idClient){
        $this -> ClientModel -> deleteClient($idClient);
    
    }

 
}



?>