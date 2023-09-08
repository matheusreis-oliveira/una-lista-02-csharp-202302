using System;

class Program
{
    static void Main()
    {
        while (Menu())
        {
            try
            {
                Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro não tratado, pressione enter para retornar ao menu.");
                Console.ReadLine();
            }
        }
    }

    static bool Menu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("- 1. Atividade 01");
            Console.WriteLine("- 2. Atividade 02");
            Console.WriteLine("- 3. Atividade 03");
            Console.WriteLine("- 4. Atividade 04");
            Console.WriteLine("- 5. Atividade 05");
            Console.WriteLine("- 6. Atividade 06");
            Console.WriteLine("- 7. Atividade 07");
            Console.WriteLine("- 8. Atividade 08");
            Console.WriteLine("- 9. Atividade 09");
            Console.WriteLine("- 10. Atividade 10");
            Console.WriteLine("- 0. Sair\n");

            Console.Write("Opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Atividade01();
                    break;
                case "2":
                    Atividade02();
                    break;
                case "3":
                    Atividade03();
                    break;
                case "4":
                    Atividade04();
                    break;
                case "5":
                    Atividade05();
                    break;
                case "6":
                    Atividade06();
                    break;
                case "7":
                    Atividade07();
                    break;
                case "8":
                    Atividade08();
                    break;
                case "9":
                    Atividade09();
                    break;
                case "10":
                    Atividade10();
                    break;
                case "0":
                    return false;
                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                    Console.ReadLine();
                    break;
            }

            Console.Clear();
        }
    }
    private static void Atividade01()
    {
        Console.WriteLine("Executando Exercício 1...");

        Console.Write("Informe o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());
        double media = (numero1 + numero2) / 2;
        Console.WriteLine("A média aritmética é: " + media);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade02()
    {
        Console.WriteLine("Executando Exercício 2...");

        Console.Write("Informe o preço do produto: ");
        double precoProduto = double.Parse(Console.ReadLine());
        double novoPreco = precoProduto * 1.10;
        Console.WriteLine("Novo valor do produto: " + novoPreco);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade03()
    {
        Console.WriteLine("Executando Exercício 3...");

        Console.Write("Informe a temperatura em graus Fahrenheit: ");
        double temperaturaFahrenheit = double.Parse(Console.ReadLine());
        double temperaturaCelsius = (temperaturaFahrenheit - 32) / 1.8;
        Console.WriteLine("A temperatura em graus Celsius é: " + temperaturaCelsius.ToString("N2"));

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade04()
    {
        Console.WriteLine("Executando Exercício 4...");

        Console.Write("Informe o valor do capital a ser aplicado: ");
        double capital = double.Parse(Console.ReadLine());
        Console.Write("Informe o prazo de aplicação em meses: ");
        int prazo = int.Parse(Console.ReadLine());
        Console.Write("Informe a taxa de juros mensal (em decimal): ");
        double taxaJuros = double.Parse(Console.ReadLine());
        double montante = capital * Math.Pow(1 + taxaJuros, prazo);
        Console.WriteLine("O montante a ser recebido é: " + montante);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade05()
    {
        Console.WriteLine("Executando Exercício 5...");

        Console.Write("Informe o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor recebido por hora de trabalho: ");
        double valorHora = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor do salário família: ");
        double salarioFamilia = double.Parse(Console.ReadLine());
        Console.Write("Informe o número de filhos com idade menor que 14 anos: ");
        int numFilhos = int.Parse(Console.ReadLine());
        double salarioBruto = (horasTrabalhadas * valorHora) + (salarioFamilia * numFilhos);
        Console.WriteLine("O salário bruto a ser recebido é: " + salarioBruto);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade06()
    {
        Console.WriteLine("Executando Exercício 6...");

        Console.Write("Informe o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número (base do logaritmo): ");
        double num2 = double.Parse(Console.ReadLine());
        double logaritmo = Math.Log(num1, num2);
        Console.WriteLine("O logaritmo do primeiro número na base do segundo número é: " + logaritmo);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade07()
    {
        Console.WriteLine("Executando Exercício 7...");

        Console.Write("Informe o salário fixo do vendedor: ");
        double salarioFixo = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor total das vendas no mês: ");
        double totalVendas = double.Parse(Console.ReadLine());
        Console.Write("Informe o percentual de comissão sobre as vendas (em decimal): ");
        double percentualComissao = double.Parse(Console.ReadLine());
        double salarioTotal = salarioFixo + (totalVendas * percentualComissao);
        Console.WriteLine("O salário total do vendedor é: " + salarioTotal);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade08()
    {
        Console.WriteLine("Executando Exercício 8...");

        Console.Write("Informe o total de veículos: ");
        int totalVeiculos = int.Parse(Console.ReadLine());
        Console.Write("Informe o total de rodas: ");
        int totalRodas = int.Parse(Console.ReadLine());
        int totalCarros = 0;
        int totalMotos = 0;
        while (totalRodas >= 4)
        {
            totalCarros++;
            totalRodas -= 4;
        }
        totalMotos = totalVeiculos - totalCarros;
        Console.WriteLine("Total de carros: " + totalCarros);
        Console.WriteLine("Total de motos: " + totalMotos);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade09()
    {
        Console.WriteLine("Executando Exercício 9...");

        Console.Write("Informe um número inteiro de segundos: ");
        int segundos = int.Parse(Console.ReadLine());
        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        int segundosRestantes = segundos % 60;
        Console.WriteLine("Horas: " + horas);
        Console.WriteLine("Minutos: " + minutos);
        Console.WriteLine("Segundos: " + segundosRestantes);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static void Atividade10()
    {
        Console.WriteLine("Executando Exercício 10...");

        Console.Write("Informe o primeiro valor: ");
        double valorA = double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        double valorB = double.Parse(Console.ReadLine());
        Console.Write("Informe o terceiro valor: ");
        double valorC = double.Parse(Console.ReadLine());
        double mediaAritmetica = (valorA + valorB + valorC) / 3;
        double mediaHarmônica = 3 / ((1 / valorA) + (1 / valorB) + (1 / valorC));
        double mediaGeometrica = Math.Pow(valorA * valorB * valorC, 1.0 / 3);
        Console.WriteLine("Média aritmética: " + mediaAritmetica);
        Console.WriteLine("Média harmônica: " + mediaHarmônica);
        Console.WriteLine("Média geométrica: " + mediaGeometrica);

        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

}
