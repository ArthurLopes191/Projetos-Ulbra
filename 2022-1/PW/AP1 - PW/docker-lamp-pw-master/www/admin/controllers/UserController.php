<?php

class UserController{

    function validateLogin(){
        
        $login = $_POST['login'];
        $password = $_POST['password'];

        require_once('models/UserModel.php');
        $UserModel = new UserModel();
        $result = $UserModel -> getUser($login);

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