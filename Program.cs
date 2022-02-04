//
//Console.WriteLine("Hello World");

using Cadastro_Pessoa_FS1.Classes;


PessoaFisica novaPf = new PessoaFisica();

//novaPf.nome = "Odirlei";
//
//Console.WriteLine("Nome: " + novaPf.nome);
//Console.WriteLine($"Nome: {novaPf.nome}");


novaPf.ValidarDataNascimento(new DateTime(2000,01,01));