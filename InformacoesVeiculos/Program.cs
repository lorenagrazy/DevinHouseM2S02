
using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Digite a marca do carro: ");
    string marca = Console.ReadLine();

    Console.Write("Digite o modelo do carro: ");
    string modelo = Console.ReadLine();

    Console.Write("Digite a km rodados do carro: ");
    int km = int.Parse(Console.ReadLine());

    Console.WriteLine("Informações do carro:");
    Console.WriteLine("Marca: {0}", marca);
    Console.WriteLine("Modelo: {0}", modelo);
    Console.WriteLine("Km rodados: {0}", km);

    if (km > 10000)
    {
      Console.WriteLine("Atenção: É necessário fazer uma revisão.");
    }

    Console.ReadKey();
  }
}

/* O programa começa solicitando ao usuário que digite a marca do carro.
O valor digitado pelo usuário é armazenado na variável "marca".
O programa solicita ao usuário que digite o modelo do carro.
O valor digitado pelo usuário é armazenado na variável "modelo".
O programa solicita ao usuário que digite a km rodados do carro.
O valor digitado pelo usuário é convertido para inteiro e armazenado na variável "km".
O programa exibe na tela as informações do carro, incluindo a marca, modelo e km rodados, utilizando o método Console.WriteLine().
O programa verifica se a km rodados do carro é maior que 10.000. Se for, o programa exibe a mensagem "Atenção: É necessário fazer uma revisão.".
Por fim, o programa espera que o usuário pressione qualquer tecla para encerrar a execução, utilizando o método Console.ReadKey(). */