using System;

namespace Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Criação de lista de conta corrente (array de ContaCorrente) em Program.cs

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(45, 12345),
                new ContaCorrente(80, 67812),
                new ContaCorrente(23, 34457)
            };

            for(int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Agência: {contas[i].Agencia} || Conta: {contas[i].Conta}");
            }
        }
    }
}