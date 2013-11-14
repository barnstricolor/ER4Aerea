using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetores4
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "ANA E MARIANA GOSTAM DE BANANA";
            string palavra = "ANA";
            Boolean bln;
            int i=0, j=0,total=0;

            for (i = 0 ; i <= texto.Length ; i++)
            {
                for (j = 0; j <= texto.Length; j++)
                {
                    total++;
                }
            }

        }
    }
}
