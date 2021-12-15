namespace exemploPOO.model
{
    public class CalculadoraComum : ICalculadora
    {
        public double Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public double Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}