using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDoPaulo = new ContaCorrente(111, 222222);

            lista.Adicionar(new ContaCorrente(889, 9989898));
            lista.Adicionar(new ContaCorrente(889, 787875));
            lista.Adicionar(new ContaCorrente(889, 544333));
            lista.Adicionar(contaDoPaulo);
            lista.Escrever();
            Console.WriteLine("Removendo item");
            lista.Remover(contaDoPaulo);
            lista.Escrever();
            Console.ReadLine();
        }       
        
        static void TestaArray()
        {
            int[] idades = new int[] { 15, 28, 35, 50, 28 };
            int media = 0;

            for (int index = 0; index < idades.Length; index++)
            {
                media += idades[index];
            }

            media = media / idades.Length;

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(0889, 00999),
                new ContaCorrente(0889, 99765),
                new ContaCorrente(0889, 99088),
                new ContaCorrente(0889, 88788),
            };

            for (int index = 0; index < contas.Length; index++)
            {
                Console.WriteLine($"Conta {index} {contas[index].Numero}");
            }
        }
    }
}
