// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

class Program
{
    static void Main(string[] args)
    {
        double nota1 = 0, nota2 = 0, peso1 = 0, peso2 = 0, mediaPonderada = 0;
        bool continuar = true;

        Console.WriteLine("Bem-vindo ao programa de cálculo da média ponderada de duas provas realizadas por um aluno!");

        while (continuar == true)
        {

            try
            {
                Console.Write("Digite a nota da primeira prova: ");
                nota1 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite o peso da primeira prova: ");
                peso1 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite a nota da segunda prova: ");
                nota2 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite o peso da segunda prova: ");
                peso2 = double.Parse(Console.ReadLine() ?? "0");

                if (peso1 <= 0 || peso2 <= 0)
                {
                    Console.WriteLine("Os pesos devem ser maiores que zero. Por favor, tente novamente.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }

            mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada das notas do aluno é: {mediaPonderada}");
        }
    }
}