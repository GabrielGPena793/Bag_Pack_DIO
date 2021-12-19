﻿using System.Collections;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[10] {100, 2, 4, 5, 0, 10, 8, 100, 2, 10};

            int maximo = arrayNumeros.Max();
            int minimo = arrayNumeros.Min();
            double medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var distinto = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Medio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array Unico: {string.Join(", ", distinto)}");




            // // pesquisa estilo sql
            // var numerosParesArray = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // //pesquisa estilo método
            // var numerosPares = arrayNumeros.Where(num => num % 2 == 0).OrderBy(num => num).ToList();

            // System.Console.WriteLine($"Números retornados pela Query {string.Join(", ",numerosParesArray)}");
            // System.Console.WriteLine($"Números retornados por Metodo {string.Join(", ",numerosParesArray)}");

            // Dictionary<string,string> estados = new Dictionary<string, string>();
            // estados.Add("PE", "Pernambuco");
            // estados.Add("SP", "São Paulo");
            // estados.Add("Rj", "Rio de Janeiro");

            // foreach (var estado in estados)
            // {
            //     System.Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
            // }

            // string valorProcurado = "ll";
            // estados.Remove(valorProcurado);
            // System.Console.WriteLine($"Removendo o valor {valorProcurado}");
            
            // foreach (var estado in estados)
            // {
            //     System.Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
            // }
            
            // if(estados.TryGetValue(valorProcurado, out string? estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Estado não encontarado");
            // }
            // System.Console.WriteLine("Valor atual");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] =  "São Paulo Atualizado";

            
            // System.Console.WriteLine("Valor atualizado");
            // System.Console.WriteLine(estados[valorProcurado]);

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push("Codigo Limpo");
            // pilhaLivros.Push("TDD");
            // pilhaLivros.Push(".NET");

            // System.Console.WriteLine($"A quantidade de livros na pilha é {pilhaLivros.Count}");

            // while(pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"O próximo livro é {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // System.Console.WriteLine($"A quantidade de livros na pilha é {pilhaLivros.Count}");
            

            // Queue<string> lista = new Queue<string>();

            // lista.Enqueue("Gabirel");
            // lista.Enqueue("José");
            // lista.Enqueue("Henrique");

            // System.Console.WriteLine($"O tamanho da fila é: {lista.Count}");

            // while(lista.Count > 0)
            // {
            //     System.Console.WriteLine($"É a vez de {lista.Peek()}");
            //     System.Console.WriteLine($"{lista.Dequeue()} Atendido");
            // }

            // System.Console.WriteLine($"O tamanho da fila é: {lista.Count}");



            // OperacoesListas opList = new OperacoesListas();
            // List<string> estados = new List<string>() {"PE", "SP", "RJ"};
            // string[] estadosArray = new string[2] {"BH", "AL"};



            // System.Console.WriteLine($"O tamanho da lista é {estados.Count}");
            // opList.ImprimirLista(estados);
            // // estados.Remove("PE"); // removendo elemento especificado
        
            // estados.AddRange(estadosArray);  // adicionando outra coleção na coleção desejada, desde que seja do mesmo tipo
            // System.Console.WriteLine($"O tamanho da lista é {estados.Count}");
            // opList.ImprimirLista(estados);




            // OperacoesArray operacoes = new OperacoesArray();
            // int[] numeros = new int[5] {10,2,8,1,6};
            // int[] numerosCopiados = new int[10];
            // string[] numerosConvertidos = operacoes.convertArray(numeros);


            // int valorProcurado = 1;

            // System.Console.WriteLine($"Array com tamanho antes do resize {numeros.Length}");

            // operacoes.RedimencionarArray(ref numeros, numeros.Length * 2);

            // System.Console.WriteLine($"Array com tamanho depois do resize {numeros.Length}");



            // int indiceDoValor = operacoes.ObterIndice(numeros, valorProcurado);

            // if(indiceDoValor >= 0)
            // {
            //     System.Console.WriteLine($" valor: {valorProcurado}, indice; {indiceDoValor}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não encontrado");
            // }


            // int valorAchado =  operacoes.ObterValor(numeros, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine($"Encontrei o valor {valorAchado}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Não tem o valor no array");

            // }
            // bool todosMaiorQue =  operacoes.TodosMaiorQue(numeros, valorProcurado);
            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine($"Todos são maiores que o valor {valorProcurado}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Existem valores menores que {valorProcurado}");
            // }

            // bool existe = operacoes.Existe(numeros, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine($"O valor {valorProcurado} existe");
            // }
            // else
            // {
            //     System.Console.WriteLine($"O valor {valorProcurado} não existe");
            // }

            // System.Console.WriteLine("Imprimeinto array normal");
            // operacoes.ImprimirArray(numeros);

            // System.Console.WriteLine("Imprimindo array ordenado");
            // // operacoes.OrdernarBubbleSort(ref numeros);
            // operacoes.Ordenar(ref numeros);
            // operacoes.ImprimirArray(numeros);

            // System.Console.WriteLine("Antes da cópia");
            // operacoes.ImprimirArray(numerosCopiados);
            
            // operacoes.CopiarArray(ref numeros, ref numerosCopiados);

            // System.Console.WriteLine("Depois da cópia");
            // operacoes.ImprimirArray(numerosCopiados);


        //     int[] arryInteiros = new int[3];
        //     arryInteiros[0] = 10;
        //     arryInteiros[1] = 20;
        //     arryInteiros[2] = 30;

        //     System.Console.WriteLine("Pecorrendo o arry com for");
        //     for (int i = 0; i < arryInteiros.Length; i++)
        //     {
        //         System.Console.WriteLine(arryInteiros[i]);
        //     }

        //     System.Console.WriteLine("Pecorrendo o arry com foreach");

        //     foreach (int valor in arryInteiros)
        //     {
        //         System.Console.WriteLine(valor);
        //     }

        //     int[,] matriz = new int[4,2]   //declarando a atribundo valores  uma matriz
        //     {
        //         {8,5},
        //         {10,20},
        //         {50,100},
        //         {70,80}
        //     };

        //     // matriz[0, 0] = 5; também da pra atribuir colocando o número da linha e coluna


        //     // pecorrendo uma matriz
        //     for (int i = 0; i < matriz.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matriz.GetLength(1); j++)
        //         {
        //             System.Console.WriteLine(matriz[i, j]);
        //         }
        //     }
        }
    }
}