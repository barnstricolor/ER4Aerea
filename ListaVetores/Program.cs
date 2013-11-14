using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetores
{
    class Program
    {
        static void Main(string[] args)
        {   
            int qtdAlunos = 0, i = 0, j = 0 ,total = 0,totalPerguntas = 0;
            int[] gabarito;
            char[] resposta;
            Boolean bln;
            Console.WriteLine("Qual a quantidade de perguntas");
            totalPerguntas = int.Parse(Console.ReadLine());

            resposta = new char[totalPerguntas];//onde sera guardado as respostas corretas
            gabarito = new int[totalPerguntas];//onde sera guardado a resposta para cada aluno

            Console.WriteLine("Quantos alunos serão avaliados"); //pergunto a quantidade de alunos
            qtdAlunos = int.Parse(Console.ReadLine());//guardo a quantidade de alunos

            for (i = 0; i < totalPerguntas; i++)//loop em todas as perguntas para saber as respostas corretas
            {
                bln = false;
                while (bln == false)
                {
                    Console.WriteLine("Qual a resposta para a pergunta de número: " + (i + 1));
                    resposta[i] = char.ToUpper( char.Parse(Console.ReadLine()));//guardo a resposta no vetor utilizando o indice                 
                    if (resposta[i] == 'A' || resposta[i] == 'B' || resposta[i] == 'C' || resposta[i] == 'D' || resposta[i] == 'E')
                    {
                        bln = true;
                    }
                    else 
                    {
                        bln = false;
                    }
                }
            } ;

            for (i = 0; i < qtdAlunos; i++)//para cada aluno eu pergunto a resposta para cada pergunta
            {
                total = 0;//zero a nota do aluno
                for (j = 0; j < totalPerguntas; j++)
                {
                    bln = false;
                    while (bln == false)
                    {
                        Console.WriteLine("Qual a resposta do aluno: " + (i + 1) + " para a pergunta " + (j + 1));
                        gabarito[j] = char.ToUpper(char.Parse(Console.ReadLine()));//joga a resposta da pergunta no indice do gabarito
                        if (resposta[j] == gabarito[j])
                        { //comparo a resposta com a pergunta, no mesmo indice dos dois vetores
                            total++;//se a resposta for igual a pergunta eu incremento 1
                        }
                        if (gabarito[j] == 'A' || gabarito[j] == 'B' || gabarito[j] == 'C' || gabarito[j] == 'D' || gabarito[j] == 'E')
                        {
                            bln = true;
                        }
                        else
                        {
                            bln = false;
                        }
                    }
                }
                Console.WriteLine("O aluno " + (i + 1) + " fez " + total + " pontos.");
            }
        }
    }
}
