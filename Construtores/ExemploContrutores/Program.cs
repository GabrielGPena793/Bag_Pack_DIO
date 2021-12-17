using ExemploContrutores.Models;

namespace ExemploConstutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Log log = Log.GetInstace();

            // log.PropriedadeLog = "Teste de log";

            // // não vai iniciar uma nova instância, vai retornar a mesma
            // Log log2 = Log.GetInstace();
            // System.Console.WriteLine(log2.PropriedadeLog);
            

            // Pessoa aluno = new Aluno("Gabriel", "Gomes");
            // Pessoa pessoa = new Pessoa("Gabriel", "Gomes");

            // pessoa.Aprensentar();

            Data data = new Data();

            data.Mes = 12;
            System.Console.WriteLine(data.Mes);

            data.AprensentarMes();
        }

    }
}

