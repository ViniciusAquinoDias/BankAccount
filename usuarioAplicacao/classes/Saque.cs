using CaixaBancario.usuarioAplicacao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaixaBancario.usuarioAplicacao.classes.ContaSaldo;

namespace CaixaBancario.usuarioAplicacao.classes
{
    internal class Saque : ContaSaldo, ISaque
    {
        private double SaqueConta(double valorTotalConta, double valorASacar, double taxa)
        {
            if (valorTotalConta < valorASacar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Operação invalida, saldo abaixo do experado");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ReadKey();
                return valorTotalConta;
            }
            else return valorTotalConta = valorTotalConta - (valorASacar - taxa);
        }

        public void Saques(ContaSaldo contaSaldo, double taxa)
        {
            Console.WriteLine("Saque:");
            var valor = opcaoMoeda("Saque");
            double valor1 = valor.Item1;
            Moeda moeda = valor.Item2;

            double saldoTotal = contaSaldo.ObterSaldoTotal(moeda);
            double novoSaldo = SaqueConta(saldoTotal, valor1, taxa);
            contaSaldo.AtualizarSaldo(moeda, novoSaldo);
        }
    }
}