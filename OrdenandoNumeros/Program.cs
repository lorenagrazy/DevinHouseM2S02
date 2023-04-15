using System;

class Program
{
  static void Main(string[] args)
  {
    int[] numeros = new int[4];

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.Write("Digite o {0}º número: ", i + 1);
      numeros[i] = int.Parse(Console.ReadLine());
    }

    Array.Sort(numeros);

    Console.WriteLine("Números ordenados:");

    for (int i = 0; i < numeros.Length; i++)
    {
      Console.WriteLine("{0}º número: {1}", i + 1, numeros[i]);
    }

    Console.ReadKey();
  }
}

/* O programa declara um array de inteiros chamado "numeros", com tamanho 4.
O programa utiliza um laço for para pedir que o usuário digite cada um dos 4 números, armazenando-os no array "numeros" através da posição i.
O método Array.Sort(numeros) é utilizado para ordenar o array "numeros" em ordem crescente.
O programa utiliza um novo laço for para imprimir os números ordenados na tela.
O programa espera que o usuário pressione qualquer tecla para encerrar a execução, utilizando o método Console.ReadKey(). */