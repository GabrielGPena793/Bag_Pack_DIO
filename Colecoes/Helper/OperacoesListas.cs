using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesListas
    {
        public void ImprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Indice: {i}, {lista[i]}");
            }
        }
    }
}