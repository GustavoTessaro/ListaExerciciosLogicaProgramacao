// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
// terreno e depois exibir a área do terreno.

class Program
{
    static void Main(string[] args)
    {
        double comprimento = 0;
        double largura = 0;
        double area = 0;

        Console.WriteLine("Bem-vindo ao programa de cálculo da área de um terreno retangular!");

        try
        {
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine() ?? "0");

            if (comprimento <= 0 || largura <= 0)
            {
                Console.WriteLine("O comprimento e a largura devem ser maiores que zero. Por favor, tente novamente.");
                return;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            return;
        }

        area = comprimento * largura;

        Console.WriteLine($"A área do terreno é: {area}");
    }
}