using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
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
            var contas = new List<ContaCorrente>() 
            {
                new ContaCorrente(123, 909090),
                null,
                new ContaCorrente(909, 7676767),
                new ContaCorrente(237, 700707),
                null,
                new ContaCorrente(980, 808080)
            };

            //contas.Sort(new ComparadorContaCorrentePorAgencia()); 

            var contasOrdenadas = contas.Where(ct => ct != null).OrderBy(ct => ct.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta: Número: {conta.Numero}, Agencia: {conta.Agencia}");
            }            

            Console.ReadLine();
        }   
        
        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Paulo",
                "José",
                "Sidney"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(2);
            idades.Add(3);
            idades.Add(4);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
