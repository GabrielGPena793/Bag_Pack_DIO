namespace exemploPOO.model
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        private bool valido;

        
        public void DefinirMedidas(double comprimento, double largura){

            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
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
                return this.comprimento * this.largura;
            }
            else
            {
                System.Console.WriteLine("Preencha os valores, com medidas válidas!");
                return 0;
            }

            
        }

    }
}