using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalVetor = 0,i=0;
            int[] x,y;
            int total=0;
            
            Console.WriteLine("Qual a quantidade de linhas do vetor");
            totalVetor = int.Parse(Console.ReadLine());

            x= new int[totalVetor];
            y= new int[totalVetor];

            for (i = 0; i < totalVetor; i++)
            {
                Console.WriteLine("Digite o valor para posição " + i + " do vetor X");
                x[i] = int.Parse(Console.ReadLine());
            };
            for (i = 0; i < totalVetor; i++)
            {
                Console.WriteLine("Digite o valor para posição " + i + " do vetor Y");
                y[i] = int.Parse(Console.ReadLine());
            };
            
            Console.WriteLine("Produto Escalar de:");
            i = 0;
            while (i < totalVetor)
            {
                //Console.WriteLine("x(" + i + ") = " + x[i] + " . y(" + i + ") = " + y[i] + " total de " + (x[i] * y[i]));
                //Console.WriteLine(x[i]*y[i]);
                total += x[i] * y[i];
                i++;
            }

            Console.WriteLine("Total de :"+total);

        }
    }
}
