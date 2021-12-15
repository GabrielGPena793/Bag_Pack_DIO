namespace exemploPOO.model
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }


        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {this.Nome}, e ganho de salário R${this.Salario}");
        }
    }
}