using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop50Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] produtos;
            int i = 0, produto = 0, total = 3, j = 0;
            
            produtos = new int[total];

            while (i < total){
                
                Console.WriteLine("Digite o produto");
                
                produto = int.Parse(Console.ReadLine());
                
                j = 0;                
                while (j <= i)
                {
                    if (produtos[j] != produto)
                    {
                        j++;
                    }
                }

                if (j >= i)
                {
                    produtos[i] = produto;
                    i++;
                }
            };

            Console.WriteLine("Impressao em ordem");
            i = 0;
            while (i<total) {
                Console.WriteLine(produtos[i].ToString());
                i++;
            }
            Console.WriteLine("Impressao inverso");
            i = total - 1;
            while (i >= 0)
            {
                Console.WriteLine(produtos[i].ToString());
                i--;
            }

        }
    }
}
