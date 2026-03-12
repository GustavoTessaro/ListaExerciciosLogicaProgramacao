// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

class Program
{
    static void Main(string[] args)
    {
        int valor1 = 0;
        int valor2 = 0;
        int valor3 = 0;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de ordenação de valores!");

        while (verificar == true)
        {
            try
            {
                Console.Write("Digite o primeiro valor inteiro: ");
                valor1 = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite o segundo valor inteiro: ");
                valor2 = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite o terceiro valor inteiro: ");
                valor3 = int.Parse(Console.ReadLine() ?? "0");

                if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
                {
                    Console.WriteLine("Os valores devem ser diferentes. Por favor, tente novamente.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }

            int[] valores = { valor1, valor2, valor3 };
            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine("Os valores em ordem decrescente são:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }

            Console.Write("Deseja ordenar outros valores? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }


    }
}