//2. Crie um programa para calcular o volume de um Cilindro

class Program
{
    static void Main(string[] args)
    {
        double raio = 0, altura = 0, volume = 0;
        bool entradaValida = false;
        bool continuar = true;
        String? resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo de volume de um cilindro!");

        while (continuar == true)
        {

            while (entradaValida == false)
            {
                try
                {
                    Console.Write("Digite o raio do cilindro: ");
                    raio = double.Parse(Console.ReadLine()?? "0");

                    Console.Write("Digite a altura do cilindro: ");
                    altura = double.Parse(Console.ReadLine()?? "0");

                    entradaValida = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é: {volume}");

            Console.Write("Deseja calcular o volume de outro cilindro? (s/n): ");
            resposta = Console.ReadLine();

            if (String.Equals(resposta, "s", StringComparison.OrdinalIgnoreCase))
            {
                entradaValida = false;
                continuar = true;
            }
            else
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar o programa de cálculo de volume. Até a próxima!");
            }

        }
    }
}
