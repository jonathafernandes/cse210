using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        int soma = 0;

        foreach (int n in numeros)
        {
            soma += n;
        }

        Console.WriteLine($"A soma é: {soma}");

        if (numeros.Count > 0)
        {
            double media = soma / numeros.Count;
            Console.WriteLine($"A média é: {media}");
        }

        int maior = numeros[0];

        foreach (int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
        }

        Console.WriteLine($"O maior valor é: {maior}");
    }
}