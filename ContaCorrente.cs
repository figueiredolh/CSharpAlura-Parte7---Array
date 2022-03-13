using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ContaCorrente
    {
        public int Agencia { get; private set; }
        public int Conta { get; private set; }
        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
        }
    }
}
