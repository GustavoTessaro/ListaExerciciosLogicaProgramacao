// 21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
// resultado.
// a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
// b. Pesquise sobre “fatorial”

class Program
{
    static void Main(string[] args)
    {
        int A = 0;
        long fatorial = 1;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo de fatorial!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite um número inteiro para calcular o fatorial: ");
                A = int.Parse(Console.ReadLine() ?? "0");

                if (A < 0)
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

            Console.Write($"{A}! = ");
            for (int i = A; i > 0; i--)
            {
                fatorial *= i;
                Console.Write(i);
                if (i > 1)
                {
                    Console.Write(" x ");
                }
            }
            Console.WriteLine($" = {fatorial}");

            Console.Write("Deseja calcular o fatorial para outro número? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }
    }
}