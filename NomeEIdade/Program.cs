using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Digite o nome do paciente: ");
    string nome = Console.ReadLine();

    Console.Write("Digite a idade do paciente: ");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Nome do paciente: {0}", nome);

    if (idade < 18)
    {
      Console.WriteLine("{0} é menor de idade.", nome);
    }
    else if (idade < 60)
    {
      Console.WriteLine("{0} é maior de idade.", nome);
    }
    else
    {
      Console.WriteLine("{0} é um idoso.", nome);
    }

    Console.ReadKey();
  }
}

/* O programa começa solicitando ao usuário que digite o nome do paciente.
O valor digitado pelo usuário é armazenado na variável "nome".
O programa solicita ao usuário que digite a idade do paciente.
O valor digitado pelo usuário é convertido para inteiro e armazenado na variável "idade".
O programa exibe na tela o nome do paciente, utilizando o método Console.WriteLine().
O programa verifica a idade do paciente. Se ele tiver menos de 18 anos, o programa exibe a mensagem "{0} é menor de idade.", onde {0} é substituído pelo nome do paciente. Se ele tiver entre 18 e 59 anos, o programa exibe a mensagem "{0} é maior de idade.". Se ele tiver 60 anos ou mais, o programa exibe a mensagem "{0} é um idoso.".
Por fim, o programa espera que o usuário pressione qualquer tecla para encerrar a execução, utilizando o método Console.ReadKey(). */