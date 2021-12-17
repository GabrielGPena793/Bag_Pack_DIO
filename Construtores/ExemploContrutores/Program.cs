using ExemploContrutores.Models;

namespace ExemploConstutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica mat = new Matematica(10,15);
            mat.Somar();


            // Operacao op = Calculadora.Somar;  pode ser chamdo assim também
            // Operacao op = new Operacao(Calculadora.Subtrair);
            // op += Calculadora.Somar;
            // op(10,10);
            // op.Invoke(5,10); outra formar de chamar o delegate


            // const int valor = 30; // não da pra mudar esse valor

            // Log log = Log.GetInstace();

            // log.PropriedadeLog = "Teste de log";

            // // não vai iniciar uma nova instância, vai retornar a mesma
            // Log log2 = Log.GetInstace();
            // System.Console.WriteLine(log2.PropriedadeLog);
            

            // Pessoa aluno = new Aluno("Gabriel", "Gomes");
            // Pessoa pessoa = new Pessoa("Gabriel", "Gomes");

            // pessoa.Aprensentar();

            // Data data = new Data();

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.AprensentarMes();
        }

    }
}

