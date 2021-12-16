namespace ExemploContrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public Pessoa()
        {
            this.nome = string.Empty;
            this.sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Aprensentar()
        {
            System.Console.WriteLine($"Olá meu nome é: {this.nome} {this.sobrenome}");
        }
    }
}