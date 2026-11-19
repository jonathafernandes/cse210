class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("João", 3, 16);
        string texto = "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.";
        Escritura escritura = new Escritura(referencia, texto);

        const int numeroParaOcultar = 3;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            if (escritura.EstaCompletamenteOculta())
            {
                break;
            }

            Console.Write("Pressione Enter para continuar ou digite 'sair' para sair: ");
            string entrada = Console.ReadLine() ?? "";

            if (entrada.Trim().Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(numeroParaOcultar);
        }
    }
}
