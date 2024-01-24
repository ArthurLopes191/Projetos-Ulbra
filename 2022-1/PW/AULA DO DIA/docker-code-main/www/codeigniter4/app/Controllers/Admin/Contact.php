<?php

namespace App\Controllers\Admin;

use CodeIgniter\Controller;
use App\Models\ContactModel;

class Contact extends Controller{

    public function listContact(){

        $contactModel = new ContactModel();
    
         $data = [
            'contacts' => $contactModel -> findAll()
        ];
    
        echo view('admin/templates/header');
        echo view('admin/contact/listContacts', $data);
        echo view('admin/templates/footer');
    }

    public function sendContact(){
        echo view('admin/templates/header');
        echo view('admin/contact/sendContact');
        echo view('admin/templates/footer');
    }

    public function sendContactAction(){
        $contactModel = new ContactModel();
        $data = [
            'name' => $this -> request -> getVar('name'),
            'email' => $this -> request -> getVar('email'),
            'message' => $this -> request -> getVar('message'),
            'status' => '0'
        ];

        $contactModel -> insert($data);
        return redirect()->to('admin/contact');
    }
}