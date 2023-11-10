// exercicio 1
partial class Program
{
    static void Main()
    {
        int A = 10;
        int B = 20;

        int temp = A;
        A = B;
        B = temp;

        Console.WriteLine("Valor A:" + A);
        Console.WriteLine("Valor B:" + B);

        //EXERCICIO 2

        // Solicitar entrada do usuário

        Console.Write("100: ");
        int totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("200: ");
        int votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("180: ");
        int votosNulos = int.Parse(Console.ReadLine());

        Console.Write("350: ");
        int votosValidos = int.Parse(Console.ReadLine());

        // Calcular percentuais
        double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
        double percentualNulos = (double)votosNulos / totalEleitores * 100;
        double percentualValidos = (double)votosValidos / totalEleitores * 100;

        // Exibir resultados
        Console.WriteLine($"5: {percentualBrancos:F2}%");
        Console.WriteLine($"4: {percentualNulos:F2}%");
        Console.WriteLine($"100: {percentualValidos:F2}%");


        //exercicio 3
        // Solicitar entrada do usuário
        Console.Write("158");
        int valor = int.Parse(Console.ReadLine());

        // Verificar se o valor é positivo ou negativo
        if (valor >= 0)

            Console.WriteLine("O valor é positivo.");

        else

            Console.WriteLine("O valor é negativo.");

        //exercicio 4
        // Solicitar entrada do usuário
        Console.Write("Digite o salário fixo do vendedor: ");
        double salarioFixo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor total das vendas efetuadas pelo vendedor: ");
        double vendas = double.Parse(Console.ReadLine());

        // Calcular comissão
        double comissao;

        if (vendas <= 1500)
        {
            comissao = vendas * 0.03; // 3% sobre o total das vendas
        }
        else
        {
            comissao = 1500 * 0.03 + (vendas - 1500) * 0.05; // 3% até R$ 1.500,00 e 5% sobre o excedente
        }

        // Calcular salário total
        double salarioTotal = salarioFixo + comissao;

        // Exibir resultado
        Console.WriteLine($"O salário total do vendedor é: {salarioTotal:C}");

        //exercicio 5
        // Solicitar entrada do usuário
        Console.Write("Digite o nome do primeiro time: ");
        string time1 = Console.ReadLine();

        Console.Write("Digite o número de gols marcados pelo primeiro time: ");
        int golsTime1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do segundo time: ");
        string time2 = Console.ReadLine();

        Console.Write("Digite o número de gols marcados pelo segundo time: ");
        int golsTime2 = int.Parse(Console.ReadLine());

        // Determinar o vencedor ou se é empate
        string vencedor;

        if (golsTime1 > golsTime2)
        {
            vencedor = time1;
        }
        else if (golsTime2 > golsTime1)
        {
            vencedor = time2;
        }
        else
        {
            vencedor = "EMPATE";
        }

        // Exibir resultado
        Console.WriteLine($"O vencedor da partida é: {vencedor}");

        //exercicio 6
        // Solicitar entrada do usuário para o primeiro valor
        Console.Write("Digite o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        // Solicitar entrada do usuário para o segundo valor
        double valor2;
        do
        {
            Console.Write("Digite o segundo valor (não pode ser zero): ");
            valor2 = double.Parse(Console.ReadLine());

            if (valor2 == 0)
            {
                Console.WriteLine("O segundo valor não pode ser zero. Por favor, digite um valor diferente.");
            }

        } while (valor2 == 0);

        // Calcular e exibir o resultado da divisão
        double resultadoDivisao = valor1 / valor2;
        Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}");

        //exercicio 7
        // Número para a tabuada
        int numero = 8;

        // Calcular e imprimir a tabuada do 8 (de 1 a 10)
        Console.WriteLine($"Tabuada do {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");


            //Exercicio 8

            // Inicializando a variável para armazenar a soma dos valores
            double soma = 0;

            // Lendo 10 valores
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                soma += valor;
            }

            // Calculando a média aritmética
            double media = soma / 10;

            // Exibindo o resultado
            Console.WriteLine($"A média aritmética dos 10 valores é: {media}");


        }
    }
}
            
          