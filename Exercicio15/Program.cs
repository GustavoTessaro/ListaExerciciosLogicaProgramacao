// 15. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
// a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
// peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
// ● IMC em adultos Condição
// ● Abaixo de 18,5
// ● Abaixo do peso
// ● Entre 18,5 e 25 Peso normal
// ● Entre 25 e 30
// ● Acima do peso
// ● Acima de 30 obeso

class Program
{
    static void Main(string[] args)
    {
        double peso = 0;
        double altura = 0;
        double imc = 0;
        bool verificar = true;
        string resposta = "";

        Console.WriteLine("Bem-vindo ao programa de cálculo do IMC!");

        while (verificar == true)
        {

            try
            {
                Console.Write("Digite o peso em kg: ");
                peso = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Digite a altura em metros: ");
                altura = double.Parse(Console.ReadLine() ?? "0");

                if (peso <= 0 || altura <= 0)
                {
                    Console.WriteLine("Peso e altura devem ser maiores que zero. Por favor, tente novamente.");
                    continue;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido para peso e altura.");
                continue;
            }

            imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }

            Console.Write("Deseja calcular o IMC para outra pessoa? (s/n): ");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "s")
            {
                verificar = false;
            }

        }


    }
}