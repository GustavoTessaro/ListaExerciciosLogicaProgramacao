// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de sequência de Fibonacci!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite um número inteiro para gerar a sequência de Fibonacci: ");
                numero = int.Parse(Console.ReadLine() ?? "0");

                if (numero < 0)
                {
                    Console.WriteLine("Número inválido. Por favor, insira um número inteiro não negativo.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                continue;
            }

            Console.WriteLine($"Sequência de Fibonacci até {numero}:");
            int a = 0, b = 1;
            while (a <= numero)
            {
                Console.Write($"{a} ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();

            Console.Write("Deseja gerar a sequência de Fibonacci para outro número? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }
    }
}