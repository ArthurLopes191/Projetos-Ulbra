<?php

class UserModel{

    var $Connection;

    function __construct(){
        require_once('db/ConnectClass.php');
        $connectClass = new ConnectClass();
        $connectClass -> openConnect();
        $this -> Connection = $connectClass -> getConn();
    }

    function getUser($userName){
        $sql = "
            SELECT * FROM users
            WHERE user='{$userName}'
        ";

        return $this -> Connection -> query($sql);
    
    }
}