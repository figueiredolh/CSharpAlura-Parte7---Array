using System;

namespace Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(123, 2435));
            lista.Adicionar(new ContaCorrente(80, 3425));
            lista.Adicionar(new ContaCorrente(50, 5521));
            lista.Adicionar(new ContaCorrente(50, 5521));
            lista.Adicionar(new ContaCorrente(30, 5412));

            lista.Adicionar(new ContaCorrente(30, 5412));
            lista.Adicionar(new ContaCorrente(30, 5412));
            lista.Adicionar(new ContaCorrente(30, 5412));
            lista.Adicionar(new ContaCorrente(30, 5412));
            lista.Adicionar(new ContaCorrente(30, 5412));

            lista.Adicionar(new ContaCorrente(30, 5412));
            lista.Adicionar(new ContaCorrente(30, 5412));

        }
    }
}