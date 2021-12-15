using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
  
            //valores válidos
            Retangulo retangulo2 = new Retangulo();
            retangulo2.DefinirMedidas(100,20);
            Console.WriteLine($"Área: {retangulo2.ObterArea()}");

            //valores inválidos
            Retangulo retangulo = new Retangulo();
            retangulo.DefinirMedidas(0,20);
            Console.WriteLine($"Área: {retangulo.ObterArea()}");





        }
    }
}