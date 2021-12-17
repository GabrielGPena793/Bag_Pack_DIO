namespace ExemploContrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Matematica(int x, int y)
        {
            this.X = x;
            this.Y = y;

            Calculadora.EventoCalculadora += EventHandler;  // inscrevendo o evento no evento da calculadora
        }
        public void Somar()
        {
            Calculadora.Somar(this.X,this.Y);
        }

        public void EventHandler() // metodo que será inscrito no evento
        {
            System.Console.WriteLine("Método Executado");
        }
    }
}