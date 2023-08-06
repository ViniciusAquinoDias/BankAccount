using CaixaBancario.usuarioAplicacao.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaBancario.usuarioAplicacao.Contas
{
    internal class ContaUsers : ContaPai
    {
        public ContaUsers(string nomeCompleto, int cpf, int senha) : base(nomeCompleto, cpf, senha)
        {
        }

        public void telaUsuario()
        {
            bool programaAtivo = true;
            while(programaAtivo)
            {
                Console.Clear();
                Console.WriteLine($"Bem Vindo {nomeCompleto}\n");
                Console.Write("Digite:\n 1: Para depositos.\n 2: Para saques.\n 3: Para ver o Saldo da conta.\n");
                Console.Write("\nSua opção -> ");
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        depositarNaConta(this);
                        break;
                    case "2":
                        sacarDaConta(this);
                        break;
                    case "3":
                        verSaldoDaConta();
                        break;
                    default:
                        Console.Write("Erro: Valor errado.");
                        break;
                }
            }

        }
    }
}
