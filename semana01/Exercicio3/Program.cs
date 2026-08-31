using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();
        int numero = geradorAleatorio.Next(1, 101);
        int palpite = -1;


        while (palpite != numero)
        {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite > numero)
            {
                Console.WriteLine("Mais baixo");
            }
            else if (palpite < numero)
            {
                Console.WriteLine("Mais alto");
            }
        }
        Console.WriteLine("Você adivinhou!");
    }
}