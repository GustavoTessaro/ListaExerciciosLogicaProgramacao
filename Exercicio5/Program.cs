// 5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
// vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

class Program
{
    static void Main(string[] args)
    {
        double salarioBase = 0, totalVendas = 0, percentualComissao = 0, salarioTotal = 0;
        bool entradaValida = false;
        bool continuar = true;
        String? resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo do salário total de um vendedor!");

        while (continuar == true)
        {

            while (entradaValida == false)
            {
                try
                {
                    Console.Write("Digite o salário base do vendedor: ");
                    salarioBase = double.Parse(Console.ReadLine()?? "0");

                    Console.Write("Digite o total de vendas realizadas pelo vendedor: ");
                    totalVendas = double.Parse(Console.ReadLine()?? "0");

                    Console.Write("Digite o percentual de comissão sobre as vendas (em %): ");
                    percentualComissao = double.Parse(Console.ReadLine()?? "0");

                    entradaValida = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            salarioTotal = salarioBase + (totalVendas * (percentualComissao / 100));

            Console.WriteLine($"O salário total do vendedor é: {salarioTotal}");

            Console.Write("Deseja calcular o salário para outro vendedor? (s/n): ");
            resposta = Console.ReadLine();

            if (String.Equals(resposta, "s", StringComparison.OrdinalIgnoreCase))
            {
                entradaValida = false;
                continuar = true;
            }
            else
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar o programa de cálculo do salário total. Até a próxima!");
            }

        }

    }
}