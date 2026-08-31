using System;

class Program
{
    static void Main(string[] args)
    {
        void ExibirBoasVindas()
        {
            Console.WriteLine("Bem-Vindo ao Programa!");
        }

        string PerguntarNomeUsuario()
        {
            Console.Write("Por favor, insira seu nome: ");
            string nome = Console.ReadLine();
            return nome;
        }

        int PerguntarNumeroFavorito()
        {
            Console.Write("Por favor, insira seu número favorito: ");
            int numeroFavorito = int.Parse(Console.ReadLine());
            return numeroFavorito;
        }

        int ElevarAoQuadrado(int numeroFavorito)
        {
            return numeroFavorito *= numeroFavorito;
        }

        void ExibirResultado(string nome, int quadrado)
        {
            Console.WriteLine($"Irmão {nome}, o quadrado do seu número é {quadrado}");
        }

        ExibirBoasVindas();
        ExibirResultado(PerguntarNomeUsuario(), ElevarAoQuadrado(PerguntarNumeroFavorito()));
    }
}