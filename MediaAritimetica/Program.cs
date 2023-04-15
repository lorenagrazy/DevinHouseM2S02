using System;

namespace MediaAritmetica
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Informe a quantidade de números que deseja calcular a média: ");
      int qtdNumeros = int.Parse(Console.ReadLine());

      int[] numeros = new int[qtdNumeros];

      for (int i = 0; i < qtdNumeros; i++)
      {
        Console.Write($"Informe o {i + 1}º número: ");
        numeros[i] = int.Parse(Console.ReadLine());
      }

      int soma = 0;
      foreach (int numero in numeros)
      {
        soma += numero;
      }

      double media = (double)soma / qtdNumeros;

      Console.WriteLine($"A média aritmética é: {media:F2}");
    }
  }
}

/* O programa começa solicitando ao usuário que informe a quantidade de números que ele deseja calcular a média. Essa informação é armazenada na variável "qtdNumeros".

Em seguida, é criado um array chamado "numeros" com o tamanho igual à quantidade informada pelo usuário.

O laço for é utilizado para solicitar ao usuário que insira cada um dos números do array, armazenando-os na posição i do array.

Depois de ter todos os números armazenados no array, é utilizado um foreach para somar todos os números.

Em seguida, é calculada a média aritmética dividindo a soma pela quantidade de números, e o resultado é armazenado na variável "media".

Finalmente, a média é exibida na tela com duas casas decimais utilizando a formatação "{media:F2}". Note que é necessário utilizar a conversão "(double)" para garantir que a divisão seja feita com números de ponto flutuante e que o resultado da média tenha casas decimais. */