using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();
        string nomeDousuario = PerguntarNomeUsuario();
        int numeroFavoritoDoUsuario = PerguntarNumeroFavorito();
        int numeroAoQuadradro = ElevarAoQuadrado(numeroFavoritoDoUsuario);

        static void ExibirBoasVindas()
        {

            Console.WriteLine("Bem-Vindo ao Programa!");
        }

        static string PerguntarNomeUsuario()
        {
            Console.Write("Por favor, insira seu nome: ");
            string nome = Console.ReadLine();

            return nome;
        }

        static int PerguntarNumeroFavorito()
        {
            Console.Write("Por favor, insira seu número favorito: ");
            int numero = int.Parse(Console.ReadLine());

            return numero;
        }

        static int ElevarAoQuadrado(int numero)
        {
            int quadrado = numero * numero;

            return quadrado;
        }

        Console.WriteLine($"{nomeDousuario}, o quadrado do seu número é {numeroAoQuadradro}");
    }
}