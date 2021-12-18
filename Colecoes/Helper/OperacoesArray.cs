namespace Colecoes.Helper
{
    public class OperacoesArray
    {


        public void OrdernarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])                             // se o elemento atual for maior que o proximo
                    {
                        temp = array[j +1];                                 // pega o valor da proxima posição e guarda numa variavel
                        array[j +1] = array[j];                             // adiciona o valor da posição anterior na proxima posição
                        array[j] = temp;                                    //  pega o valor da variavel e coloca na posição anterior
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            string linha = string.Join(", ", array);                        // separando cada posição do meu array por virgula e unindo em uma string
            System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);                                              // Ordenando o array
        }

        public void CopiarArray(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);                  // Copiando todos os elementos de um array e passando para outro
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, element => element == valor);        // verificando se existe um valor igual ao que estou procurando
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, element => element > valor);     // verificando se todos so valores são maiores ao valor que estou passando
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);          // Procura o valor e retorna a primeira ocorrência que achar, se não achar retorna 0
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);                             // retorna o indice do valor se achar, se não retorna -1
        }

        public void RedimencionarArray(ref int[] array, int valor)
        {
            Array.Resize(ref array, valor);                                 // mudando o tamanho do array já existente
        }

        public string[] convertArray(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString());  // convertendo todos so valores do array de inteiros para outro array de string
        }
    }
}