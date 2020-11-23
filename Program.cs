using System;

namespace Exercicio1_Fixacao_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[10];//array para receber e armazenar os 10 valores em suas posições

            int maior, menor;//variáveis maior e menor

            
            for (var i = 0; i < 10; i++)//estrutura de repetição do tipo for
            {
                
            Console.WriteLine("Digite o valor: ");//exibição da mensagem
            valor[i] = int.Parse(Console.ReadLine());//entrada e armazenamento do valor
                        
            }

            //for para captar o maior valor dentre os 10

            maior = valor[0];// variável maior = o valor da primeira posição    
            for (var i = 1; i < 10; i++)
            {
                if(valor[i] > maior)//se valor for maior que variável maior,então
                {
                    maior = valor[i];//substitua o valor pela variável maior 
                }
            }

            Console.WriteLine( "O maior valor é: "+maior);//exibição da mensagem

            //for para captar o menor valor dentre os 10

            menor = valor[0];// variável menor = o valor da primeira posição
            for (var i = 1; i < 10; i++)
            {
                if(valor[i] < menor)//se valor for menor do que a variável menor,então
                {
                    menor = valor[i];//substitua o valor pela variável menor 
                }
            }

            Console.WriteLine("O menor valor é: "+menor);//exibição da mensagem

            
        }
    }
}

// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

