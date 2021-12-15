using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Aluno aluno = new Aluno();
            aluno.Idade = 25;
            aluno.Nome =  "Jorge";
            aluno.nota = 9;
            aluno.Apresentar();

            
            Professor professor = new Professor();
            professor.Idade = 42;
            professor.Nome =  "Dioclecio";
            professor.Salario = 4000;
            professor.Apresentar();




        }
    }
}