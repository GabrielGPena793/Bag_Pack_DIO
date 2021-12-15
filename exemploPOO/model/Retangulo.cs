namespace exemploPOO.model
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;

        private bool valido;

        
        public void DefinirMedidas(double Comprimento, double Largura){

            if(Comprimento > 0 && Largura > 0)
            {
                this.Comprimento = Comprimento;
                this.Largura = Largura;
                this.valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
        }

        public double ObterArea(){

            if(this.valido)
            {
                return this.Comprimento * this.Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha os valores, com medidas válidas!");
                return 0;
            }

            
        }

    }
}