<?php

class UserModel{

    var $Connection;

    function __construct(){
        require_once('db/ConnectClass.php');
        $connectClass = new ConnectClass();
        $connectClass -> openConnect();
        $this -> Connection = $connectClass -> getConn();
    }

    function getUser($login){
        $sql = "
            SELECT * FROM users
            WHERE user='{$login}'
        ";

        return $this -> Connection -> query($sql);
    
    }
}