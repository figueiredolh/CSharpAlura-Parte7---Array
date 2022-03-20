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
        public override bool Equals(object? obj)
        {
            ContaCorrente? outraConta = obj as ContaCorrente;
            if (outraConta == null || outraConta is not ContaCorrente) {
                return false;
            };
            return Agencia == outraConta.Agencia && Conta == outraConta.Conta;
        }
    }
}
