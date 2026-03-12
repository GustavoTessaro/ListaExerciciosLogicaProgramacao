// 17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
// contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
// variável C e mostrar seu conteúdo na tela.

class Program
{
    static void Main(string[] args)
    {
        int A = 0;
        int B = 0;
        int C = 0;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de comparação e cálculo!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite o valor de A: ");
                A = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite o valor de B: ");
                B = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                continue;
            }

            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"Os valores são iguais. A soma de A + B é: {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"Os valores são diferentes. A multiplicação de A * B é: {C}");
            }

            Console.Write("Deseja comparar outros valores? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }
    }
}