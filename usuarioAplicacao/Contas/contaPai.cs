using CaixaBancario.usuarioAplicacao.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static CaixaBancario.usuarioAplicacao.classes.ContaSaldo;

namespace CaixaBancario.usuarioAplicacao.Contas
{
    internal class ContaPai : ContaSaldo
    {
        private string _nomeCompleto;
        private int _cpf, _senha;
        private bool _Continuar = false;
        public ContaPai(string nomeCompleto, int cpf, int senha)
        {
            _nomeCompleto = nomeCompleto;
            _cpf = cpf;
            _Continuar = true;
            _senha = senha;

        } //construtor
        public string nomeCompleto
        {
            get { return _nomeCompleto; }
            set { _nomeCompleto = value; }
        } //getters e setters
        public int cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        } //getters e setters
        public int senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        } //getters e setters

        internal void depositarNaConta(ContaSaldo contaSaldo)
        {
            var deposito = new Depositor();
            deposito.Depositos(contaSaldo, 0);

        }
        internal void sacarDaConta(ContaSaldo contaSaldo)
        {
            var saqueConta = new Saque();
            saqueConta.Saques(contaSaldo, 0);
        }
        internal void verSaldoDaConta()
        {
            VerSaldo();
        }
    }
}