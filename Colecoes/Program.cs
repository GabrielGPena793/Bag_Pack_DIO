using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray operacoes = new OperacoesArray();
            int[] numeros = new int[5] {10,2,8,1,6};
            int[] numerosCopiados = new int[10];
            string[] numerosConvertidos = operacoes.convertArray(numeros);


            // int valorProcurado = 1;

            // System.Console.WriteLine($"Array com tamanho antes do rezise {numeros.Length}");

            // operacoes.RedimencionarArray(ref numeros, numeros.Length * 2);

            // System.Console.WriteLine($"Array com tamanho depois do rezise {numeros.Length}");



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
