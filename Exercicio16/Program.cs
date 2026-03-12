// Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de verificação de número par ou ímpar!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                continue;
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }

            Console.Write("Deseja verificar outro número? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }

    }
}