using System;

namespace CalculadoraSimples
{
  class Program
  {
    static void Main(string[] args)
    {
      bool sair = false;

      while (!sair)
      {
        Console.WriteLine("----- CALCULADORA SIMPLES -----");
        Console.WriteLine("Escolha o índice da operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");

        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 5)
        {
          sair = true;
          Console.WriteLine("Obrigado por utilizar a calculadora!");
        }
        else
        {
          Console.WriteLine("Digite o primeiro número:");
          double num1 = double.Parse(Console.ReadLine());

          Console.WriteLine("Digite o segundo número:");
          double num2 = double.Parse(Console.ReadLine());

          switch (escolha)
          {
            case 1:
              Console.WriteLine($"Resultado: {num1 + num2}");
              break;
            case 2:
              Console.WriteLine($"Resultado: {num1 - num2}");
              break;
            case 3:
              Console.WriteLine($"Resultado: {num1 * num2}");
              break;
            case 4:
              if (num2 == 0)
              {
                Console.WriteLine("Não é possível dividir por zero!");
              }
              else
              {
                Console.WriteLine($"Resultado: {num1 / num2}");
              }
              break;
            default:
              Console.WriteLine("Opção inválida!");
              break;
          }

          Console.WriteLine();
        }
      }
    }
  }
}
