using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
        }
    }

    class TesteProtected : ModificadoresTeste
    {
        public TesteProtected()
        {
            MetodoProtected();
        }
    }
    
    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Vísivel fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivate()
        {
            // Vísivel apenas dentro da classe "ModificadoresTeste"
        }

        protected void MetodoProtected()
        {
            // Vísivel apenas na classe "ModificadoresTeste" e derivados(herancas)
        }

        internal void MetodoInternal()
        {
            // Vísivel apenas no Projeto ByteBank.Modelos
        }
    }
}
