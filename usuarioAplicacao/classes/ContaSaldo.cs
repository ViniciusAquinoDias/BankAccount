using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaixaBancario.usuarioAplicacao.classes.ContaSaldo;
namespace CaixaBancario.usuarioAplicacao.classes
{
    public class ContaSaldo
    {
        public enum Moeda
        {
            Real,
            Dolar,
            Euro,
            PesoArgentino
        }
        internal Dictionary<Moeda, double> ListaDeMoedasDaConta;
        public ContaSaldo()
        {
            ListaDeMoedasDaConta = new Dictionary<Moeda, double>
        {
            { Moeda.Real, 0.0 },          
            { Moeda.Dolar, 0.0 },
            { Moeda.Euro, 0.0 },
            { Moeda.PesoArgentino, 0.0 }
        };
        }
        private double metodosConta(string operacaoDaConta, string nomeMoeda, double[] colecaoDaMoeda)
        {
            Console.WriteLine($"tabela de {operacaoDaConta} da moeda {nomeMoeda}:\n");
            for (var i = 0; i < colecaoDaMoeda.Length; i++)
            {
                Console.WriteLine($"Digite {i} para {operacaoDaConta}: {colecaoDaMoeda[i]}");
            }
            Console.Write("Sua opção -> ");
            int moedaEscolhida = Convert.ToInt16(Console.ReadLine());
            double moedaEscolha = colecaoDaMoeda[moedaEscolhida];
            return (moedaEscolha);
        }
        internal (double, Moeda) opcaoMoeda(string operacaoDaConta)
        {
            Console.Clear();
            double[] valorReal = new double[10] { 0.05, 0.10, 0.25, 0.50, 1.00, 10.00, 20.00, 50.00, 100.00, 200.00 };
            double[] valorEuro = new double[11] { 0.01, 0.05, 0.10, 0.20, 0.50, 3.00, 5.00, 15.00, 20.00, 50.00, 100.00};
            double[] valorDolar = new double[11] { 0.01, 0.05, 0.10, 0.25, 0.50, 1.00, 10.00, 20.00, 50.00, 100.00, 200.00 };
            double[] valorPesoArgentino = new double[11] { 0.05, 0.10, 0.25, 0.55, 2.00, 5.00, 15.00, 20.00, 50.00, 100.00, 200.00 };
            Moeda moeda;
            var retorno = true;
            while (retorno == true)
            {
                Console.WriteLine($"Para realizar o {operacaoDaConta} digite: \n\n0:Real. \n1:Dólar. \n2:Euro. \n3:Peso-Argentino.\n4:Para sair.\n");
                Console.Write("Sua opção -> ");
                var moedaString = Console.ReadLine();
                Console.Clear();
                if (moedaString == "4")
                {
                    retorno = false;
                }
                else if (Enum.TryParse(moedaString, out moeda))
                {
                    if (moeda == Moeda.Real)
                    {
                        return (metodosConta(operacaoDaConta, "Real", valorReal), Moeda.Real);
                    }
                    else if (moeda == Moeda.Dolar)
                    {
                        return (metodosConta(operacaoDaConta, "Dólar", valorDolar), Moeda.Dolar);
                    }
                    else if (moeda == Moeda.Euro)
                    {
                        return (metodosConta(operacaoDaConta, "Euro", valorEuro), Moeda.Euro);
                    }
                    else if (moeda == Moeda.PesoArgentino)
                    {
                        return (metodosConta(operacaoDaConta, "Peso-Argentino", valorPesoArgentino), Moeda.PesoArgentino);
                    }
                    else
                    {
                        Console.WriteLine("Esta moeda não existe no sistema!.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Valor Errado!");
                }
                Console.Clear();
            }
            return (0, Moeda.Dolar);
        }
        internal double ObterSaldoTotal(Moeda pegaSaldoDeDeterminadaMoeda)
        {
            return ListaDeMoedasDaConta[pegaSaldoDeDeterminadaMoeda];
        }
        internal void AtualizarSaldo(Moeda pegaMoedaPraDeterminarNovoValor, double determinaNovoSaldoDaMoedaDaConta)
        {
            ListaDeMoedasDaConta[pegaMoedaPraDeterminarNovoValor] = determinaNovoSaldoDaMoedaDaConta;
        }
        internal void VerSaldo()
        {
            Console.Clear();
            Console.WriteLine("Saldo em todas as moedas:\n");


            foreach (var saldoDaConta in ListaDeMoedasDaConta)
            {
                if (saldoDaConta.Value == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{saldoDaConta.Key}: {saldoDaConta.Value}");
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{saldoDaConta.Key}: {saldoDaConta.Value}");
                } 
            }
            //neste foreach estou percorrendo toda a 'ListaDeMoedasDaconta', e exibindo o valor

            Console.ForegroundColor = ConsoleColor.Gray; // voltando a cor original do console
            Console.Write("\nAperte qualquer tecla para voltar.");
            Console.ReadKey();
        }
    }
}