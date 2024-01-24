using Sistema_Escolar;

Professor professor = new Professor("José", 45);
Aluno aluno = new Aluno("Tiago", 16);
Escola escola = new Escola();

Console.WriteLine(escola.ApresentarPessoa(professor));

Console.WriteLine(escola.ApresentarPessoa(aluno));
