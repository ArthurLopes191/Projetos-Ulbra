<?php
namespace App\Controllers\Admin;

use CodeIgniter\Controller;
use App\Models\ClientModel;

class Client extends Controller{

    public function listClients(){
        $clientModel = new ClientModel();

        $data = [
            'clients' => $clientModel -> listClient()
        ];

        echo view('admin/templates/header');
        echo view('admin/client/listClients', $data);
        echo view('admin/templates/footer');
    }

    public function detailsClient($idClient){
        $clientModel = new ClientModel();
        $data = [
            'client' => $clientModel -> listClient($idClient)
        ];

        echo view('admin/templates/header');
        echo view('admin/client/detailsClient', $data);
        echo view('admin/templates/footer');
    }

    public function insertClient(){
        echo view('admin/templates/header'); 
        echo view('admin/client/insertClient');
        echo view('admin/templates/footer');
    }

    public function insertClientAction(){
        $clientModel = new ClientModel();
        $data = [
            'name' => $this -> request -> getVar('name'),
            'email' => $this -> request -> getVar('email'),
            'phone' => $this -> request -> getVar('phone'),
            'address' => $this -> request -> getVar('address')
        ];

        $clientModel -> insert($data);
        return redirect()->to('admin/listClients');
    }

    public function updateClient($idClient){
        $clientModel = new ClientModel();
        $data = [
            'client'  => $clientModel -> listClient($idClient)
        ];

        echo view('admin/templates/header');
        echo view('admin/client/updateClient', $data);
        echo view('admin/templates/footer');
    }

    public function updateClientAction($idClient){
        $clientModel = new ClientModel();
        $data = [
            'name' => $this -> request -> getVar('name'),
            'phone' => $this -> request -> getVar('phone'),
            'email' => $this -> request -> getVar('email'),
            'address' => $this -> request -> getVar('address')
        ];

        $clientModel -> update($idClient, $data);
        return redirect()->to('admin/listClients');
    }

    public function deleteClient($idClient){
        $clientModel = new ClientModel();
        $clientModel -> delete($idClient);
        return redirect()->to('admin/listClients');
    }

    public function searchClient(){
        $clientModel = new ClientModel();
        $search = [
            'clients' => $clientModel -> getClientsFor($_POST['search'])
        ];

        echo view('admin/templates/header');
        echo view('admin/client/listClients', $search);
        echo view('admin/templates/footer');
    }

    public function listClientsApi(){
        $clientModel = new ClientModel();

        $data = [
            'clients' => $clientModel -> listClient()
        ];

        echo view('admin/templates/header');
        echo (json_encode($data));
        echo view('admin/templates/footer');
    }
}
