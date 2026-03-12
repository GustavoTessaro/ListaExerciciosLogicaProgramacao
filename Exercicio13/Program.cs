// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

class Program
{
    static void Main(string[] args)
    {
        double A = 0;
        double B = 0;
        double C = 0;

        Console.WriteLine("Bem-vindo ao programa de comparação de soma!");

        try
        {
            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine() ?? "0");
        }
        catch (System.Exception)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            return;
        }

        if ((A + B) < C)
        {
            Console.WriteLine($"A soma de A + B ({A + B}) é menor que C ({C}).");
        }
        else
        {
            Console.WriteLine($"A soma de A + B ({A + B}) não é menor que C ({C}).");
        }
    }
}