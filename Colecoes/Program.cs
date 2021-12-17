namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int[] arryInteiros = new int[3];
            // arryInteiros[0] = 10;
            // arryInteiros[1] = 20;
            // arryInteiros[2] = 30;

            // System.Console.WriteLine("Pecorrendo o arry com for");
            // for (int i = 0; i < arryInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arryInteiros[i]);
            // }

            // System.Console.WriteLine("Pecorrendo o arry com foreach");

            // foreach (int valor in arryInteiros)
            // {
            //     System.Console.WriteLine(valor);
            // }

            int[,] matriz = new int[4,2]   //declarando a atribundo valores  uma matriz
            {
                {8,5},
                {10,20},
                {50,100},
                {70,80}
            };

            // matriz[0, 0] = 5; também da pra atribuir colocando o número da linha e coluna


            // pecorrendo uma matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}
