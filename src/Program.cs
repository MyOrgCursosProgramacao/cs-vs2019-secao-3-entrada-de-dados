using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de fixação 02: Entrada de dados em c#");
            Console.WriteLine();

            Console.Write("Entre com o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Quantos quartos têm na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Quartos: {quartos}");
            Console.WriteLine($"Preco: {preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            Console.WriteLine($"Último nome: {vet[0]}");
            Console.WriteLine($"Idade: {int.Parse(vet[1])}");
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine($"Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
