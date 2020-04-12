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

            //string urlParametros = "https://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorDeValorURL extrator = new ExtratorDeValorURL(urlParametros);

            //string valor = extrator.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaOrigem: " + valor);

            //string valorMoedaDestino = extrator.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valorMoedaDestino);


            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoTeste = "auosduoda adbau 4002-8922 asdnoadnd asinodo";

            Match resultado = Regex.Match(textoTeste, padrao);



            Console.WriteLine(resultado);
            Console.ReadLine();
        }        
    }
}
