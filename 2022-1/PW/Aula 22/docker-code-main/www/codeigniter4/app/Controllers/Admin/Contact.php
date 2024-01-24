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
}