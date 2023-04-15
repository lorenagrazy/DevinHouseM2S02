using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Digite um número inteiro: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
      Console.WriteLine("{0} é um número par.", numero);
    }
    else
    {
      Console.WriteLine("{0} é um número ímpar.", numero);
    }

    Console.ReadKey();
  }
}

/* O programa começa solicitando ao usuário que digite um número inteiro.
O valor digitado pelo usuário é armazenado na variável "numero".
O programa verifica se o número é par ou ímpar, utilizando a operação módulo (%). Se o resultado da divisão do número por 2 for igual a zero, isso significa que ele é par, caso contrário, ele é ímpar.
Se o número for par, o programa exibe na tela a mensagem "{0} é um número par.", utilizando o método Console.WriteLine(), onde {0} é substituído pelo valor de "numero".
Se o número for ímpar, o programa exibe na tela a mensagem "{0} é um número ímpar.", utilizando o método Console.WriteLine(), onde {0} é substituído pelo valor de "numero".
Por fim, o programa espera que o usuário pressione qualquer tecla para encerrar a execução, utilizando o método Console.ReadKey(). */
