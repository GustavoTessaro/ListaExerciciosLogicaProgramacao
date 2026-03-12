// 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
// impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

class Program
{
    static void Main(string[] args)
    {
        double salarioInicial = 0;
        double salarioAumentado = 0;
        double salarioFinal = 0;

        Console.WriteLine("Bem-vindo ao programa de cálculo de aumento salarial!");

        try
        {
            Console.Write("Digite o salário do funcionário: ");
            salarioInicial = double.Parse(Console.ReadLine() ?? "0");

            if (salarioInicial < 0)
            {
                Console.WriteLine("O salário não pode ser negativo. Por favor, tente novamente.");
                return;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido para o salário.");
            return;
        }

        salarioAumentado = salarioInicial * 1.15; // Aumento de 15%
        salarioFinal = salarioAumentado * 0.92; // Desconto de 8%

        Console.WriteLine($"Salário inicial: R$ {salarioInicial:F2}");
        Console.WriteLine($"Salário com aumento: R$ {salarioAumentado:F2}");
        Console.WriteLine($"Salário final após desconto de impostos: R$ {salarioFinal:F2}");
    }
}