using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorDeValorURL
    {
        private readonly string _argumentos;
        public string URL { get;}
        public ExtratorDeValorURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento Url não pode ser nulo ou vazio");
            }

            _argumentos = url.Substring(url.IndexOf('?') + 1);

            URL = url;
        }

        public string GetValor(string parametro)
        {
            string termo = parametro.ToUpper() + "=";
            int indiceTermo = _argumentos.ToUpper().IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indice = resultado.IndexOf('&');

            if (indice <= 0)
            {
                return resultado;
            }

            return resultado.Remove(indice);
        }
    }
}
