using System;

namespace Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //Adicionando contas correntes

            lista.Adicionar(new ContaCorrente(123, 2435));
            lista.Adicionar(new ContaCorrente(80, 3425));
            lista.Adicionar(new ContaCorrente(50, 5111));
            lista.Adicionar(new ContaCorrente(50, 5521));
            lista.Adicionar(new ContaCorrente(30, 5412));

            //Removendo uma conta

            lista.Remover(new ContaCorrente(50, 5111));

            //Buscar uma ContaCorrente pelo indice

            var getCcPorMetodo = lista.GetItemNoIndice(2);
            Console.WriteLine(getCcPorMetodo.Conta);

            var getCcPorIndexador = lista[2];
            Console.WriteLine(getCcPorIndexador.Conta);

            Console.WriteLine("Os dois CC são iguais: " + (getCcPorMetodo.Conta == getCcPorIndexador.Conta));
        }
    }
}