using Cadastro_Pessoa_FS1.Classes;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
=====================================================
/       Bem vindo ao sistema de cadastro de         /
/       Pessoas Físicas e Jurídicas                 /
=====================================================
");

BarraCarregamento("Carregando ", 500);
//Console.ResetColor();
string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
/       Escolha uma das opções abaixo       /
/-------------------------------------------/
/              1- Pessoa Física             /
/              2- Pessoa Jurídica           /
/                                           /
/              0- Sair                      /
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Odirlei";
            novaPf.dataNascimento = "01/01/2000";
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 15000.5f;

            novoEnd.logradouro = "Alamenda Barão de limeira";
            novoEnd.numero = 539;
            novoEnd.complemento = "SENAI Informatica";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.Clear();
            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Razão Social Pj";
            novaPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Alamenda Barão de limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "SENAI Informatica";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {metodoPj.ValidarCnpj("00.000.000/0000-00")}");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;

        case "0":
        BarraCarregamento("Finalizando ", 300);
            break;

        default:
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(1000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". "); //não pula linha; Writeline pula linha.
        Thread.Sleep(tempo);
    }
}