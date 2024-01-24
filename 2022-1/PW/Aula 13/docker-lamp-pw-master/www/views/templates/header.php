<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="css/style.css"/>
    <link href="https://fonts.googleapis.com/css2?family=Lato&display=swap" rel="stylesheet">
    <script src="assets/js/script.js"></script>
    <title>Revisão</title>
</head>

<body>
    <header class="p-5 text-white text-center bg-dark">
        <h2>HEADER</h2>
    </header>
   
    <section class="row">
         <nav class="col-md-4 p-3">
            <h3>MENU</h3>
            <ul class="nav flex-column">
                <li class="nav-item">
                  <a class="nav-link" href="?controller=site&action=home">Home</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="?controller=site&action=about">Sobre</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="?controller=site&action=products">Produtos e Serviços</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="?controller=site&action=contact">Formulário de contato</a>
                </li>
                <h3>Clientes</h3>
                <li class="nav-item">
                <a class="nav-link" href="?controller=client&action=insertClient">Cadastro cliente</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="?controller=client&action=listClients">Lista cliente</a>
                </li>
              </ul>
            </nav>
            <article class="col-md-8 p-3">
            