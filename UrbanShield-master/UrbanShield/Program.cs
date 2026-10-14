using System;
// Variável utilizada no menu
int opcao;
Usuario[] usuarios = new Usuario[10];
int quantidadeUsuario = 0;
Monitoramento monitoramento = new Monitoramento();

void CadastrarUsuario()
{
    if (quantidadeUsuario < usuarios.Length)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite seu email: ");
        string email = Console.ReadLine()!;
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine()!;

        usuarios[quantidadeUsuario] = new Usuario(nome, email, senha);
        quantidadeUsuario++;
        Console.WriteLine("\nUsuario cadastrado com sucesso!");
    }
    else
    {
        Console.WriteLine("Limite de usuario atingido.");
    }
}

void FazerLogin()
{
    Console.Write("Digite seu email: ");
    string email = Console.ReadLine()!; 
    Console.Write("Digite sua senha: ");
    string senha = Console.ReadLine()!;
    Console.Clear();

    for (int i = 0; i < quantidadeUsuario; i++)
    {
        if (usuarios[i].Email == email && usuarios[i].Senha == senha)
        {
            Console.Clear();
            Console.WriteLine($"\nBem-vindo, {usuarios[i].Nome}!");

            // Menu de escolha
            Console.WriteLine("=====================================================================");
            Console.WriteLine(" Aplicativo Inteligente de Monitoramento Urbano e Prevenção de Furtos");
            Console.WriteLine("=====================================================================");
            Console.WriteLine("\n=========================================================");
            Console.WriteLine("Deseja compartilhar seus dados e iniciar o monitoramento ? ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("\n1 - Sim");
            Console.WriteLine("2 - Não");
            int opcaoMonitoramento = Convert.ToInt32(Console.ReadLine());

            switch (opcaoMonitoramento)
            {
                case 1:
                    monitoramento.SimularMonitoramento();
                    break;
                case 2:
                    Console.WriteLine("\nMonitoramento não iniciado.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }

            return;
        }
    }
    Console.WriteLine("\nEmail ou senha incorretos.");
}

do
{
    Console.Clear();
    Console.WriteLine("=====================================================================");
    Console.WriteLine(" Aplicativo Inteligente de Monitoramento Urbano e Prevenção de Furtos");
    Console.WriteLine("=====================================================================");
    Console.WriteLine("1 - Deseja realizar o cadastro no sistema?");
    Console.WriteLine("2 - Deseja realizar o Login no sistema?");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            CadastrarUsuario();
            break;
        case 2:
            Console.Clear();
            FazerLogin();
            break;
        case 0:
            Console.WriteLine("Sistema encerrado.");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
} while (opcao != 0);