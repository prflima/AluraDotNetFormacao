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
            var contas = new List<ContaCorrente>() 
            {
                new ContaCorrente(123, 909090),
                new ContaCorrente(123, 7676767),
                new ContaCorrente(123, 700707),
                new ContaCorrente(123, 808080)
            };

            contas.Sort(); // não ordena classe, resolução na próxima aula

            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
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
