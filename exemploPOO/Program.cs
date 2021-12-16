using System;
using exemploPOO.Helper;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            string Caminho = "/home/penax/Trabalhando_com_Arquivos";
            FileHelper helper = new FileHelper();
            
            List<string> Linhas = new List<string> {"linha1", "linha2", "linha3"};
            List<string> LinhasAdicionais = new List<string> {"linha4", "linha5", "linha6"};

            // var caminhoPathCombine = Path.Combine(Caminho, "Pasta_Test1");
            var CaminhoArquivoTexto = Path.Combine(Caminho, "Texto.txt");
            var CaminhoArquivoTextoCopia = Path.Combine(Caminho, "Texto_bkp.txt");

            var novoCaminhoArquivoTexto = Path.Combine(Caminho, "Pasta_test2", "TextoStream.txt");

            // helper.ListarDiretorios(Caminho);
            // helper.ListarArquivosDiretorios(Caminho);
            // helper.CriarDiretorio(caminhoPathCombine); // criando a pastas no caminho especificado com o Patch.Combine
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(CaminhoArquivoTexto, "Criando meu primeiro arquivo com C#");
            // helper.CriarArquivoStream(CaminhoArquivoTexto, Linhas); 
            // helper.AdicionandoTextoStream(CaminhoArquivoTexto, LinhasAdicionais);
            // helper.LerArquivoStream(CaminhoArquivoTexto);
            // helper.MoverArquivo(CaminhoArquivoTexto, novoCaminhoArquivoTexto, false);
            // helper.CopiarArquivo(CaminhoArquivoTexto, CaminhoArquivoTextoCopia, false);
            helper.DeletarArquivo(CaminhoArquivoTextoCopia);
  
            // Aluno aluno = new Aluno();
            // aluno.Idade = 25;
            // aluno.Nome =  "Jorge";
            // aluno.nota = 9;
            // aluno.Apresentar();

            
            // Professor professor = new Professor();
            // professor.Idade = 42;
            // professor.Nome =  "Dioclecio";
            // professor.Salario = 4000;
            // professor.Apresentar();

            // Calculadora calculadora = new Calculadora();

            // System.Console.WriteLine($"Resultado da primeira soma {calculadora.somar(5,10)}");
            // System.Console.WriteLine($"Resultado da segunda soma {calculadora.somar(5,10,20)}");


            // Conta conta = new ContaCorrente();

            // conta.Creditar(200);
            // conta.ExibirSaldo();

            // ICalculadora calc = new Calculadora();

            // System.Console.WriteLine(calc.Somar(20,30));
            // System.Console.WriteLine(calc.Subtrair(20,30));
            // System.Console.WriteLine(calc.Dividir(20,2));
            // System.Console.WriteLine(calc.Multiplicar(20,30));




        }
    }
}