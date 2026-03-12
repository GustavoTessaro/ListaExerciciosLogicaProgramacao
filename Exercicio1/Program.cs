//1. Crie um programa para calcular o volume de uma caixa retangular

class Program
{
    static void Main(string[] args)
    {
        double comprimento = 0, largura = 0, altura = 0, volume = 0;
        bool entradaValida = false;
        bool continuar = true;
        String? resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo de volume de uma caixa retangular!");

        while (continuar == true)
        {

            while (entradaValida == false)
            {
                try
                {
                    Console.Write("Digite o comprimento da caixa: ");
                    comprimento = double.Parse(Console.ReadLine());

                    Console.Write("Digite a largura da caixa: ");
                    largura = double.Parse(Console.ReadLine());

                    Console.Write("Digite a altura da caixa: ");
                    altura = double.Parse(Console.ReadLine());

                    entradaValida = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }

            volume = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa é: {volume}");

            Console.Write("Deseja calcular o volume de outra caixa? (s/n): ");
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

