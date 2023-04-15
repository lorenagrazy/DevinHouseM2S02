using System;

class Program
{
  static void Main(string[] args)
  {
    int[] numeros = new int[5];

    for (int i = 0; i < 5; i++)
    {
      Console.Write("Digite o {0}º número: ", i + 1);
      numeros[i] = int.Parse(Console.ReadLine());
    }

    int maior = numeros[0];

    for (int i = 1; i < 5; i++)
    {
      if (numeros[i] > maior)
      {
        maior = numeros[i];
      }
    }

    Console.WriteLine("O maior número digitado foi: {0}", maior);
  }
}


/* Explicação do código:

Declara-se um array de inteiros chamado numeros, com tamanho 5.
Com o laço for, pede-se ao usuário que digite cada um dos 5 números, armazenando-os no array numeros.
Declara-se uma variável maior, inicializada com o primeiro número digitado pelo usuário.
Com outro laço for, compara-se cada um dos números armazenados no array numeros com a variável maior, atualizando-a caso o número em questão seja maior que o armazenado em maior.
Por fim, imprime-se na tela o maior número digitado pelo usuário.
Observação: esse código considera que o usuário irá digitar apenas números inteiros. Caso o usuário digite um valor inválido, o programa irá lançar uma exceção. Para lidar com essa situação, é necessário implementar um tratamento de exceções adequado. */