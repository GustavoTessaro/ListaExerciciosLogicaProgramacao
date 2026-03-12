// 3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
// programa deve solicitar ao usuário:
// ● A quilometragem inicial do veículo no início da viagem.
// ● A quilometragem final ao término da viagem.
// ● A quantidade de combustível consumida durante a viagem (em litros).

class Program
{
    static void Main(string[] args)
    {
        double quilometragemInicial = 0, quilometragemFinal = 0, combustivelConsumido = 0, consumoPorKm = 0;
        bool entradaValida = false;
        bool continuar = true;
        String? resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo de consumo de combustível por quilômetro percorrido!");

        while (continuar == true)
        {

            while (entradaValida == false)
            {
                try
                {
                    Console.Write("Digite a quilometragem inicial do veículo no início da viagem: ");
                    quilometragemInicial = double.Parse(Console.ReadLine()?? "0");

                    Console.Write("Digite a quilometragem final ao término da viagem: ");
                    quilometragemFinal = double.Parse(Console.ReadLine()?? "0");

                    Console.Write("Digite a quantidade de combustível consumida durante a viagem (em litros): ");
                    combustivelConsumido = double.Parse(Console.ReadLine()?? "0");

                    entradaValida = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            consumoPorKm = combustivelConsumido / (quilometragemFinal - quilometragemInicial);

            Console.WriteLine($"O consumo de combustível por quilômetro percorrido é: {consumoPorKm} litros/km");

            Console.Write("Deseja calcular o consumo para outra viagem? (s/n): ");
            resposta = Console.ReadLine();

            if (String.Equals(resposta, "s", StringComparison.OrdinalIgnoreCase))
            {
                entradaValida = false;
                continuar = true;
            }
            else
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar o programa de cálculo de consumo de combustível. Até a próxima!");
            }

        }
    }
}