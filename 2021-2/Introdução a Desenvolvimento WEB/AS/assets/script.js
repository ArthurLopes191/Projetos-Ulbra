$(document).ready(function(){

    $("#flip1").click(function(){
        $("#text1").slideDown("slow");
    });
});

function validarEmail(){
    var nome = formuser.nome.value;
    var email = formuser.email.value;
    var assunto = formuser.assunto.value;
    var mensagem = formuser.mensagem.value;

    if(nome == ""){
        alert("Preencha o campo Nome");
        formuser.nome.focus();
        return false;
    }

    if(email == "" || email.indexOf('@') == -1){
        alert("Preencha o campo E-mail");
        formuser.nome.focus();
        return false;
    }

    if(assunto == ""){
        alert("Preencha o campo Assunto");
        formuser.nome.focus();
        return false;
    }

    if(mensagem == ""){
        alert("Preencha o campo Mensagem");
        formuser.nome.focus();
        return false;
    }
}    