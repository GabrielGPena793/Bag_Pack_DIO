namespace exemploPOO.model
{
    public class ContaCorrente : Conta
    {
        private double Tarifa { get; set; }

        public override void Creditar(double valor)
        {   
          base.Saldo += valor;
        }
    }
}