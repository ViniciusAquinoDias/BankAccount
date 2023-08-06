using CaixaBancario.usuarioAplicacao.interfaces;
using System;
using static CaixaBancario.usuarioAplicacao.classes.ContaSaldo;

namespace CaixaBancario.usuarioAplicacao.classes
{
    public class Depositor : ContaSaldo, IDeposito
    {
        private double DepositarNaConta(double valorTotalConta, double valorADepositar, double taxa)
        {
            return valorTotalConta = valorTotalConta + (valorADepositar - taxa);
        }
        public void Depositos(ContaSaldo contaSaldo, double taxa)
        {
            Console.WriteLine("Depósito:");

            var valor = opcaoMoeda("Depósito");
            double valor1 = valor.Item1;
            Moeda moeda = valor.Item2;

            double saldoTotal = contaSaldo.ObterSaldoTotal(moeda);
            double novoSaldo = DepositarNaConta(saldoTotal, valor1, taxa);
            contaSaldo.AtualizarSaldo(moeda, novoSaldo);

        }
    }
}
