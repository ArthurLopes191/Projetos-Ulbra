$(document).ready(function(){

    $("#flip1").click(function(){
        $("#text1").slideDown("slow");
    });

    $('#search').click(function(){
        var cep = $('#cep').val();
        var url = 'https://viacep.com.br/ws/' + cep + '/json/';
        $.get(url, function(data){
            $('#result').html(
                'Localidade: ' + data.localidade + '<br>' +
                'Código IBGE: ' + data.ibge
            )
        });
    });
});

