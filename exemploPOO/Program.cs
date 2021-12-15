using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
  
            // Aluno aluno = new Aluno();
            // aluno.Idade = 25;
            // aluno.Nome =  "Jorge";
            // aluno.nota = 9;
            // aluno.Apresentar();

            
            // Professor professor = new Professor();
            // professor.Idade = 42;
            // professor.Nome =  "Dioclecio";
            // professor.Salario = 4000;
            // professor.Apresentar();

            // Calculadora calculadora = new Calculadora();

            // System.Console.WriteLine($"Resultado da primeira soma {calculadora.somar(5,10)}");
            // System.Console.WriteLine($"Resultado da segunda soma {calculadora.somar(5,10,20)}");


            Conta conta = new ContaCorrente();

            conta.Creditar(200);
            conta.ExibirSaldo();
            


        }
    }
}