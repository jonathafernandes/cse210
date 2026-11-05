using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual foi o percentual da sua nota? ");
        string resposta = Console.ReadLine();
        int nota = int.Parse(resposta);
        string letra;

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"Sua nota final é: {letra}");

        if (letra == "A" || letra == "B" || letra == "C")
        {
            Console.WriteLine("Parabéns! Você está aprovado!");
        } else
        {
            Console.WriteLine("Você está reprovado! Mas não desista, tente uma outra vez.");
        }
    }
}