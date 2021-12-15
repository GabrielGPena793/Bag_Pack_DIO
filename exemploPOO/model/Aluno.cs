namespace exemploPOO.model
{
    public class Aluno : Pessoa
    {
        public float nota { get; set;}


           public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {this.Nome}, sou um aluno de nota {this.nota}");
        }
    }
}