// 8. Crie um programa para verificar se um número é primo.

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        bool continuar = true;

        Console.WriteLine("Bem-vindo ao programa de verificação de número primo!");

        while (continuar == true)
        {

            try
            {
                Console.Write("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine() ?? "0");

                if (numero < 2)
                {
                    Console.WriteLine("Números menores que 2 não são considerados primos. Por favor, tente novamente.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                continue;
            }

            bool ehPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo == true)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
    }
}