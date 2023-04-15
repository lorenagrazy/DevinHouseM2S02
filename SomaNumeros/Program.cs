using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite o primeiro número: ");
    int numero1 = int.Parse(s: Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    int numero2 = int.Parse(s: Console.ReadLine());

    int soma = numero1 + numero2;

    Console.WriteLine("A soma de {0} e {1} é igual a {2}.", numero1, numero2, soma);

    Console.ReadKey();
  }
}
/* O programa começa solicitando ao usuário que digite o primeiro número inteiro.
O valor digitado pelo usuário é armazenado na variável "numero1".
O programa então solicita ao usuário que digite o segundo número inteiro.
O valor digitado pelo usuário é armazenado na variável "numero2".
A soma dos dois números é armazenada na variável "soma".
O programa exibe na tela a mensagem "A soma de {0} e {1} é igual a {2}." utilizando o método Console.WriteLine(), onde {0}, {1} e {2} são placeholders que são substituídos pelos valores de "numero1", "numero2" e "soma", respectivamente.
Por fim, o programa espera que o usuário pressione qualquer tecla para encerrar a execução, utilizando o método Console.ReadKey().
 */