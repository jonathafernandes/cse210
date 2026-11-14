using System;

// Além dos requisitos básicos, o menu valida a entrada do usuário: textos e números
// fora de 1 a 5 mostram uma mensagem e permitem tentar novamente sem encerrar o programa.
class Program
{
    static void Main(string[] args)
    {
        int respostaMenu;
        Diario diario = new Diario();

        do
        {
            Console.WriteLine("Bem-Vindo ao seu diário!");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            string opcao = Console.ReadLine();

            if (!int.TryParse(opcao, out respostaMenu) || respostaMenu < 1 || respostaMenu > 5)
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 5.");
                continue;
            }

            if (respostaMenu == 1)
            {
                string perguntaSorteada = new GeradorDePerguntas().ObterPerguntaAleatoria();

                string perguntaAleatoria = perguntaSorteada;
                Console.WriteLine(perguntaAleatoria);
                string respostaPerguntaAleatoria = Console.ReadLine();

                Registro registro = new Registro();
                registro._data = DateTime.Now.ToShortDateString();
                registro._textoPergunta = perguntaSorteada;
                registro._textoResposta = respostaPerguntaAleatoria;

                diario.AdicionarRegistro(registro);
            }
            else if (respostaMenu == 2)
            {
                diario.ExibirTodos();
            }
            else if (respostaMenu == 3)
            {
                Console.Write("Qual o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();

                diario.CarregarDoArquivo(nomeArquivo);
            }
            else if (respostaMenu == 4)
            {
                Console.Write("Qual o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();

                diario.SalvarNoArquivo(nomeArquivo);
            }
        }
        while (respostaMenu != 5);
    }
}
