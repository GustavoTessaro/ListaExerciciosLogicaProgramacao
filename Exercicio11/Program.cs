// 11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
// Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
// de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

class Program
{
    static void Main(string[] args)
    {
        string nome = "", resposta = "";
        int idade = 0;
        int diasVida = 0;
        bool verificar = true;

        Console.WriteLine("Bem-vindo ao programa de cálculo de dias de vida!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine() ?? "";

                Console.Write("Digite a sua idade (em anos completos): ");
                idade = int.Parse(Console.ReadLine() ?? "0");

                if (idade < 0)
                {
                    Console.WriteLine("A idade não pode ser negativa. Por favor, tente novamente.");
                    return;
                }

                if (idade == 0)
                {
                    Console.WriteLine("Valor nulo ou zero para idade. Por favor, insira uma idade válida.");
                    continue;
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido para a idade.");
                return;
            }

            diasVida = idade * 365;

            Console.WriteLine($"{nome.ToUpper()}, VOCÊ JÁ VIVEU {diasVida} DIAS.");

            Console.Write("Deseja calcular para outra pessoa? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }

    }


}