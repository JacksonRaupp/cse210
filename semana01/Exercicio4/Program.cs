using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        List<int> numeros = new List<int>();
        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        int soma = 0;
        float media;
        int maiorNumero = 0;
        int i;

        for (i = 0; i < numeros.Count; i++)
        {
            soma += numeros[i];

            if (numeros[i] > maiorNumero)
            {
                maiorNumero = numeros[i];
            }
        }

        media = ((float)soma) / (i - 1);

        Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"A maior numero é: {maiorNumero}");
    }
}