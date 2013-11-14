using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcluiVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista,listaAuxiliar;
            int i = 0, posicao = 0, total = 3,posicaoExcluir,j=0;

            lista = new int[total];
            listaAuxiliar = new int[total];

            for (i=0;i<total;i++)
            {
                Console.WriteLine("Digite um valor para posicao "+i);
                posicao = int.Parse(Console.ReadLine());

                lista[i] = posicao;

            };

            Console.WriteLine("Impressao em ordem");
            i = 0;
            while (i < total)
            {
                Console.WriteLine("posico " + i + " = " + lista[i].ToString());
                i++;
            }

            Console.WriteLine("Qual posicao excluir ?");
            posicaoExcluir = int.Parse(Console.ReadLine());

            for (i = 0 , j = 0 ; i < total; i++ , j++ )
            {
                if (i == posicaoExcluir){
                    i++;
                }
                if (i < total)
                {
                    listaAuxiliar[j] = lista[i];
                }
            }
            Console.WriteLine("Impressao em ordem");
            i = 0;
            while (i < total)
            {
                Console.WriteLine("posico " + i + " = " + listaAuxiliar[i].ToString());
                i++;
            }

        }
    }
}
