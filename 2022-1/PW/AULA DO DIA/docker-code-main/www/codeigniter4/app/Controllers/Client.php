<?php

namespace App\Controllers;

use App\Models\ClientModel;
use CodeIgniter\Controller;

class Client extends Controller{
    
    public function listClient(){
        $clientModel = new ClientModel();
        $clientModel -> listClient();

        $data=[
            'clients' => $clientModel -> listClient()
        ];

        echo view('templates/header');
        echo view('client/listClients', $data);
        echo view('templates/footer');
    }

    public function detailsClient($idClient){
        $clientModel = new ClientModel();
        $data = [
            'client'  => $clientModel -> listClient($idClient)
        ];

        echo view('templates/header');
        echo view('client/detailsClient', $data);
        echo view('templates/footer');
    }
}