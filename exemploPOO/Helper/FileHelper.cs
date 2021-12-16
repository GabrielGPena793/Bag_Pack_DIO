namespace exemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string path)
        {
            //me retorna um array com todos os Diretórios a partir do caminho que eu passar
            var retornoCaminho = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var item in retornoCaminho)
            {
                System.Console.WriteLine(item);
            }
        }


        public void ListarArquivosDiretorios(string path)
        {
            //me retorna um array com todos os arquivos a partir do caminho que eu passar
            // posso passar no segundo argumento funciona como um filtro, * = a tudo , *1.png = estou especificando que pode ser qualquer coisa antes e que termine com "1.png"
            var retornoArquivos = Directory.GetFiles(path, "*1.png" , SearchOption.AllDirectories);

            foreach (var item in retornoArquivos)
            {
                System.Console.WriteLine(item);
            }

        }

        public void CriarDiretorio(string caminho)
        {
            // cria repositório no caminho que eu passar
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string Caminho, bool Apagar)
        {
            // para apagar recursivamente o arquivo tem que passar 2 parâmentros , o caminho e a confirmação se quer ou não apagar recursivamente
            Directory.Delete(Caminho, Apagar);
        }


        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            //cria um arquivo passando o caminho e o conteudo, porém ele sobrescreve o arquivo caso já exista,
            // para isso não acontecer colocamos uma condicioal verificando se já existe
            if(!File.Exists(caminho)) // se existe vai ser true e estou negando para que ele não faça se existir, só se for false
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoStream(string caminho, List<string> conteudo)
        {
            // criando arquivos e escrevendo linha por linha
            // using é resposavel por terminar essa stream, para garantir que o processo vai ser liberado para outro processo poder trabalhar, com o using garante que isso aconteça
            using (var Stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    Stream.WriteLine(linha);
                }
            }
        }

        //adicioanndo normal
        public void AdicionandoTexto(string caminho, string conteudo)
        {
            //adicionando sem stream
            File.AppendAllText(caminho,conteudo);
        }

        //adicioanndo normal com stream
        public void AdicionandoTextoStream(string caminho, List<string> conteudo)
        {
            // Adicionando texto a um arquivo e escrevendo linha por linha, usando stream
            using (var Stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    Stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            // vai pegar todo meu conteudo e colocar em uma array, e depois estou escrendo isso no console
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }


        //lendo com stream
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty; // iniciando com string vazia

            using (var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null ) // pra cada linha adiciona na variável linha e escreve no  console. até não ter mais nenhuma!
                {
                    System.Console.WriteLine(linha);
                }
            }

        }

        //Mover arquivos, passando 3 paramentros caso queria confirmar um sobrescrita de uma arquivo se já existir um com o mesmo nome;
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever );
        }

        //Copiando arquivos, passando 3 paramentros caso queria confirmar um sobrescrita de uma arquivo se já existir um com o mesmo nome;
        public void CopiarArquivo(string caminho, string copiando, bool sobrescrever)
        {
            File.Copy(caminho, copiando, sobrescrever);
        }

        //Deletar arquivos
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}