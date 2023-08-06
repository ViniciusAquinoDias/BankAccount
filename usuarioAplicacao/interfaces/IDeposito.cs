using CaixaBancario.usuarioAplicacao.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaixaBancario.usuarioAplicacao.classes.ContaSaldo;

namespace CaixaBancario.usuarioAplicacao.interfaces
{
    internal interface IDeposito
    {
        public void Depositos(ContaSaldo contaSaldo, double taxa);
    }
}
