// 20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
// tabuada na forma:
// ● 0 x N = 0,
// ● 1 x N = 1N,
// ● 2 x N = 2N,
// .
// .
// .
// ● 10 x N = 10N.

class Program
{
    static void Main(string[] args)
    {
        int N = 0;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de tabuada!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite um número inteiro entre 1 e 10: ");
                N = int.Parse(Console.ReadLine() ?? "0");

                if (N < 1 || N > 10)
                {
                    Console.WriteLine("Número inválido. Por favor, insira um número entre 1 e 10.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                continue;
            }

            Console.WriteLine($"Tabuada de {N}:");
            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * N;
                Console.WriteLine($"{i} x {N} = {resultado}");
            }

            Console.Write("Deseja calcular a tabuada para outro número? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }
    }
}