namespace ExemploContrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Olá sou um aluno");
        }   
    }
}