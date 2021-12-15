using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome =  "Gabriel";
            p1.Idade = 25;

            p1.Apresentar();
        }
    }
}