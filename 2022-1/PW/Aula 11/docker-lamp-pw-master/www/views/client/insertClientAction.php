<h1>Dados do Cliente</h1>
<table class="table table-striped">
    <tr>
        <th>
            Nome:
        </th>
        <td>
            <?= $client['name'] ?>
        </td>
    </tr>

    <tr>
        <th>
            Senha:
        </th>
        <td>
            <?= $client['password'] ?>
        </td>
    </tr>

    <tr>
        <th>
            Sexo:
        </th>
        <td>
            <?= isset($_POST['sexo'])

            ?>
        </td>
    </tr>

    <tr>
        <th>
            Checkbox:
        </th>
        <td>
            <?= $client['checkbox[]'] ?>
        </td>
    </tr>

    <tr>
        <th>
            Mensagem:
        </th>
        <td>
            <?= $client['message'] ?>
        </td>
    </tr>

    <tr>
        <th>
            Select:
        </th>
        <td>
            <?= $client['select']?>
        </td>
    </tr>
</table>