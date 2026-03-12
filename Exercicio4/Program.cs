// 4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

class Program
{
    static void Main(string[] args)
    {
        double temperaturaCelsius = 0, temperaturaFahrenheit = 0;
        bool entradaValida = false;
        bool continuar = true;
        String? resposta = "";

        Console.WriteLine("Bem-vindo ao programa de conversão de temperatura de Celsius para Fahrenheit!");

        while (continuar == true)
        {

            while (entradaValida == false)
            {
                try
                {
                    Console.Write("Digite a temperatura em Celsius: ");
                    temperaturaCelsius = double.Parse(Console.ReadLine()?? "0");
                    entradaValida = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaFahrenheit} °F");

            Console.Write("Deseja converter outra temperatura? (s/n): ");
            resposta = Console.ReadLine();

            if (String.Equals(resposta, "s", StringComparison.OrdinalIgnoreCase))
            {
                entradaValida = false;
                continuar = true;
            }
            else
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar o programa de conversão de temperatura. Até a próxima!");
            }

        }

    }
}