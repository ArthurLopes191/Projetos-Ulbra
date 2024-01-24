<?php

class UserController{

    var $UserModel;

    function __construct(){
        require_once('models/UserModel.php');
        $this -> UserModel = new UserModel();
    }
    
    function validateLogin(){
        
        $login = $_POST['login'];
        $password = $_POST['password'];
        $result = $this -> UserModel -> getUser($login);

        if($user = $result -> fetch_assoc()){
            if($user['password']==$password){
                $_SESSION['user'] = $user;
                header('Location:index.php?controller=main&action=index');
            }else{
                print('Senha incorreta!!!');
            }
        }else{
            print('Usuário não existe!!!');
        }

        //$_SESSION['user'] = 'dados';
    }
}