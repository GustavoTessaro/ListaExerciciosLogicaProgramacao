// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

class Program
{
    static void Main(string[] args)
    {
        List<double> notas = new List<double>();
        double mediaHarmonica = 0, quantidadeNotas = 0;
        bool continuar = true;
        String? resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo da média harmônica das notas de um aluno!");

        while (continuar == true)
        {

            try
            {
                Console.Write("Digite a quantidade de notas do aluno: ");
                quantidadeNotas = double.Parse(Console.ReadLine() ?? "0");

                if (quantidadeNotas <= 0)
                {
                    Console.WriteLine("A quantidade de notas deve ser maior que zero. Por favor, tente novamente.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }


            for (int i = 0; i < quantidadeNotas; i++)
            {

                try
                {
                    Console.Write($"Digite a {i + 1}ª nota do aluno: ");
                    notas.Add(double.Parse(Console.ReadLine() ?? "0"));
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                    i--;
                }

            }

            double somaReciprocos = 0;
            foreach (double nota in notas)
            {
                somaReciprocos += 1 / nota;
            }

            mediaHarmonica = quantidadeNotas / somaReciprocos;

            Console.WriteLine($"A média harmônica das notas do aluno é: {mediaHarmonica}");

            Console.Write("Deseja calcular a média para outro aluno? (s/n): ");
            resposta = Console.ReadLine();

            if (String.Equals(resposta, "s", StringComparison.OrdinalIgnoreCase))
            {
                notas.Clear();
                continuar = true;
            }
            else
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar o programa de cálculo da média harmônica. Até a próxima!");
            }

        }

    }
}