using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira uma nota numérica: ");
        string notaTexto = Console.ReadLine();

        int notaNumero = int.Parse(notaTexto);

        string notaLetra;

        if (notaNumero >= 90)
        {
            notaLetra = "A";
        }
        else if (notaNumero >= 80)
        {
            notaLetra = "B";
        }
        else if (notaNumero >= 70)
        {
            notaLetra = "C";
        }
        else if (notaNumero >= 60)
        {
            notaLetra = "D";
        }
        else
        {
            notaLetra = "F";
        }

        Console.WriteLine($"Nota: {notaLetra}");

        if (notaLetra == "A" || notaLetra == "B" || notaLetra == "C")
        {
            Console.WriteLine("Parabéns! Aprovado! 🥳");
        }
        else
        {
            Console.WriteLine("Não foi dessa vez! Mais sorte na próxima 🤞🏻");
        }

    }
}