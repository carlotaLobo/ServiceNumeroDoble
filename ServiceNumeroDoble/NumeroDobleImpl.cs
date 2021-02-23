using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNumeroDoble
{
    public class NumeroDobleImpl : INumeroDobleContract
    {
        public int GetNumeroDoble(int numero)
        {
            return numero * 2;
        }

        public string Invisible()
        {
            throw new NotImplementedException();
        }

        public string GetSaludo(string nombre)
        {
            return "Hola, " +  nombre;
        }
    }
}
