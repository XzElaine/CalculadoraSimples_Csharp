using System;

Console.WriteLine("Olá, seja bem-vindo a calculadora.");
Console.WriteLine("----------------------------------");
Console.WriteLine("Digite a opção que deseja executar: ");
Console.WriteLine("[1] Soma");
Console.WriteLine("[2] Subtração");
Console.WriteLine("[3] Multiplicação");
Console.WriteLine("[4] Divisão");
Console.WriteLine("[0] Sair");

int opcaoEscolhida = int.Parse(Console.ReadLine());

switch (opcaoEscolhida)
{
    case 0:
        Console.WriteLine("Você escolheu sair.");
        break;
    case 1:
        Console.WriteLine("A opção escolhida foi: Soma");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Digite o primeiro número: ");
        double numero1_Soma = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2_Soma = double.Parse(Console.ReadLine());

        double resultadoSoma = numero1_Soma + numero2_Soma;
        Console.WriteLine("O valor da soma dos dois números informados equivale a: " + resultadoSoma);

        break;
    case 2:
        Console.WriteLine("A opção escolhida foi: Subtração");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Digite o primeiro número: ");
        double numero1_Subtracao = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2_Subtracao = double.Parse(Console.ReadLine());

        double resultadoSubtracao = numero1_Subtracao - numero2_Subtracao;
        Console.WriteLine("O valor da subtração dos dois numeros informados equivale a: " + resultadoSubtracao);

        break;
    case 3:
        Console.WriteLine("A opção escolhida foi: Multiplicação");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Digite o primeiro número: ");
        double numero1_multiplicacao = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2_multiplicacao = double.Parse(Console.ReadLine());

        double resultadoMultiplicacao = numero1_multiplicacao * numero2_multiplicacao;
        Console.WriteLine("O valor da multiplicação dos dois numeros informados equivale a: " + resultadoMultiplicacao);

        break;
    case 4:
        Console.WriteLine("A opção escolhida foi: Divisão");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Digite o primeiro número: ");
        double numero1_divisao = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2_divisao = double.Parse(Console.ReadLine());

        if (numero1_divisao == 0 || numero2_divisao == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
        else
        {

            double resultadoDivisao = numero1_divisao / numero2_divisao;
            Console.WriteLine("O valor da divisão dos dois numeros informados equivale a: " + resultadoDivisao);
        }
        break;
}