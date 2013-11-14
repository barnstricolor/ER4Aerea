using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int face = 0, i = 0, parcial=0;
            int[] resultados;
            Boolean bln,blnAux;

            resultados = new int[6];

            blnAux = false;
            while (blnAux == false){
                bln = false;
                while (bln == false){
                    Console.WriteLine("O dado foi lançado, qual o valor da face ?. (informe zero para sair)");
                    face = int.Parse(Console.ReadLine());
                    if (face == 1 || face == 2 || face == 3 || face == 4 || face == 5 || face == 6){
                        bln = true;
                    } else {
                        if (face == 0)
                        {
                            bln = true;
                        }
                        else
                        {
                            Console.WriteLine("Informe valor de 1 a 6");
                            bln = false;
                        }
                    }
                }
                if (face == 0){
                    blnAux = true;
                }else{
                    parcial = resultados[face - 1];
                    parcial++;
                    resultados[face - 1] = parcial;
                }
            }

            Console.WriteLine("Total de Ocorrencias");
            i = 0;
            while (i < 6)
            {
                Console.WriteLine("Total da face (" + ( i + 1 )+ ") = "+  resultados[i].ToString());
                i++;
            }


        }
    }
}
