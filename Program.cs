using CaixaBancario.usuarioAplicacao;
using CaixaBancario.usuarioAplicacao.Contas;

var Continuar = true;

while (Continuar)
{
    Console.WriteLine("Caixa Bancario\n");
    Console.WriteLine("Digite 1: Login");
    Console.WriteLine("Digite 2: Cadastro");
    Console.WriteLine("Digite 0: Sair\n"); //pulo 2 linhas do console

    Console.Write("Sua Opção -> ");
    var opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Login\nOpção ainda em construção...");
            Console.ReadKey();
            Console.Clear();
            break;

        case "2":

            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual o seu cpf? ");
            int cpf = (int)Convert.ToInt64(Console.ReadLine());

            Console.Write("Qual a sua senha?(Deve conter somente 4 números) ");
            int senha = Convert.ToInt32(Console.ReadLine());

            if (senha < 1000 || senha == 0000 || senha >= 9999 || senha == 1111 || nome == "")
            {
                Console.Write("Sua conta não atende os requesitos minímos para ser criada");
                Console.ReadKey();
                Console.Clear();
                break;
            }
                ContaUsers contaCliente = new ContaUsers(nome, cpf, senha);
                contaCliente.telaUsuario();
            break;
        case "0":
            Continuar = false;
            break;
        default:
            Console.WriteLine("Caminho inexistente!");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}