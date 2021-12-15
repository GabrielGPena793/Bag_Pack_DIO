namespace exemploPOO.model
{
    public abstract class Conta
    {
        protected double Saldo { get; set; }

        public abstract void Creditar(double valor);

        public void ExibirSaldo(){
            System.Console.WriteLine($"O saldo da conta é {this.Saldo}");
        }
    }
}