using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _lista;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int capacidade = 5) //Criação de argumento opcional
        {
            _lista = new ContaCorrente[capacidade];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente conta)
        {
            VerificarCapacidade(_proximaPosicao);
            _lista[_proximaPosicao] = conta;
            Console.WriteLine($"Agência: {conta.Agencia} || Conta: {conta.Conta} || Posição {_proximaPosicao}");
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente conta)
        {
            for(int i = 0; i < _proximaPosicao; i++)
            {
                if (_lista[i].Equals(conta))
                {
                    Console.WriteLine($"Item removido: Agência: {_lista[i].Agencia} || Conta: {_lista[i].Conta} ");
                    
                    _proximaPosicao--;
                    //int indice = i;
                    for(int j = i; j < _proximaPosicao; j++)
                    {
                        _lista[j] = _lista[j + 1];
                    }
                    _lista[_proximaPosicao] = null;
                    break;
                }
            }
        }

        public void VerificarCapacidade(int tamanho)
        {
            if(tamanho < _lista.Length)
            {
                return;
            }

            AmpliarCapacidade(tamanho);
        }

        public void AmpliarCapacidade(int tamanho)
        {
            int novoTamanho = tamanho * 2;

            Console.WriteLine($"Ampliando tamanho da array para {novoTamanho} posições. (Anteriormente {tamanho} posições)");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for(int i = 0; i < _lista.Length; i++)
            {
                novoArray[i] = _lista[i];
            }

            _lista = novoArray;
        }
    }
}
