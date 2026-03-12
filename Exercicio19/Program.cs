// 19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
// encontram no conjunto dos números de 1 até 500.

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        Console.WriteLine("Soma dos números ímpares que são múltiplos de três entre 1 e 500:");

        for (int i = 1; i <= 500; i++)
        {
            if (i % 2 != 0 && i % 3 == 0)
            {
                soma += i;
            }
        }

        Console.WriteLine($"A soma é: {soma}");
    }
}