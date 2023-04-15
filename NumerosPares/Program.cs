using System;

class Program
{
  static void Main(string[] args)
  {
    int numero;

    do
    {
      Console.Write("Digite um número inteiro positivo: ");
      numero = int.Parse(Console.ReadLine());
      if (numero <= 0)
      {
        Console.WriteLine("Número inválido! Digite um número inteiro positivo.");
      }
    } while (numero <= 0);

    Console.WriteLine("Números pares de 0 até {0}:", numero);

    for (int i = 0; i < numero; i += 2)
    {
      Console.Write(i + " ");
    }

    Console.WriteLine();
  }
}

/* Inicia-se declarando a variável numero como int e recebe um valor digitado pelo usuário por meio do Console.ReadLine(). Como estamos esperando um número inteiro, utilizamos a conversão int.Parse() para transformar a entrada em um inteiro;
Em seguida, utiliza-se um laço de repetição do-while para verificar se o número digitado pelo usuário é válido (ou seja, positivo). Enquanto o número for menor ou igual a 0, o programa exibirá uma mensagem de erro e solicitará que o usuário digite novamente um número válido;
Após ter um número válido, é exibido na tela a mensagem "Números pares de 0 até [numero digitado pelo usuário]:";
Por fim, é utilizado um laço de repetição for para percorrer todos os números pares de 0 até o número informado pelo usuário (incrementando de 2 em 2 a cada iteração) e exibir cada um dos números pares na tela. Note que o laço não inclui o próprio número informado pelo usuário se ele for ímpar. */