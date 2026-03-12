// 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
// pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
// dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
// contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
// de pães e de broas, e depois calcular os dados solicitados.

class Program
{
    static void Main(string[] args)
    {
        int quantidadePao = 0;
        int quantidadeBroa = 0;
        double precoPao = 0.12;
        double precoBroa = 1.50;
        double totalArrecadado = 0;
        double valorPoupanca = 0;

        Console.WriteLine("Bem-vindo ao programa de cálculo de arrecadação da padaria Hotpão!");

        try
        {
            Console.Write("Digite a quantidade de pães vendidos: ");
            quantidadePao = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a quantidade de broas vendidas: ");
            quantidadeBroa = int.Parse(Console.ReadLine() ?? "0");

            if (quantidadePao < 0 || quantidadeBroa < 0)
            {
                Console.WriteLine("A quantidade de pães e broas não pode ser negativa. Por favor, tente novamente.");
                return;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            return;
        }

        totalArrecadado = (quantidadePao * precoPao) + (quantidadeBroa * precoBroa);
        valorPoupanca = totalArrecadado * 0.10;

        Console.WriteLine($"O total arrecadado com a venda dos pães e broas é: R$ {totalArrecadado:F2}");
        Console.WriteLine($"O valor a ser guardado na poupança (10% do total arrecadado) é: R$ {valorPoupanca:F2}");
    }
}