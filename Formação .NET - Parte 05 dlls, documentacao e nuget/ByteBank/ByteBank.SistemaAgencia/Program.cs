using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2020, 05, 30);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferencaEntreDatas = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferencaEntreDatas);
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }        
    }
}
