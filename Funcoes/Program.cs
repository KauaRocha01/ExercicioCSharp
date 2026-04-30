namespace Funcoes;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        /*
            TipodeRetorno NomeDaFuncao(parametro)
            {
                    comandos da função
            }
        */
        
        //  static void MostrarMensagem()
        //  {
        //      Console.WriteLine("Olá, Boa tarda!");
        //  }

        //  MostrarMensagem();

        //! função com parametro


        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        // }    

        // Saudacao("Kesia");

        // static int Somar(int a, int b)
        // {
        //     return a + b;
        // }

        // int resultado = Somar(10, 2);
        // Console.WriteLine(resultado);

        // static void ExibirDobro(int num)
        // {
        //     Console.WriteLine(num * 2);
        // }

        // ExibirDobro(10);

        // int[] numeros = new int[5];

        // Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;

        // Console.WriteLine(numeros);

        // Console.WriteLine(string.Join(", ", numeros));



    //     string[] nomes = {"Penelope", "Juan", "Davi"};

    //     for(int i = 0; i < nomes.Length; i++)
    //     {
    //         Console.WriteLine(nomes[i]);
    //     }


    //  static double CalcularMedia(double[] notas) 
    //  {
    //     double soma = 0;

    //      for(int i = 0; i < notas.Length; i++)
    //      {
    //          soma += notas[i];
    //      }
    //      return soma / notas.Length;
    //  }

    //   double[] notasAluno = {8.0, 7.5, 9.0, 6.5};

    //  double media = CalcularMedia(notasAluno);

    //    Console.WriteLine($"Média final: {media}");
    
    //    int[] numeros = new int[5];
    //   int soma = 0;

    //  for(int i = 0; i < numeros.Length; i ++)
    //  {
    //  Console.WriteLine($"Digite o {i + 1}º número: ");
    //      numeros[i] = int.Parse(Console.ReadLine());

    //      soma += numeros[i];
    //  }

    // Console.WriteLine(string.Join(",", numeros));
    // Console.WriteLine($"A soma dos numeros é {soma}" );






    //Desafio
        string[] alunos = { "Kaua", "Sofia", "Beatriz" };

       
        string[] notas = new string[3];

       
        for (int i = 0; i < alunos.Length; i++)
        {
        Console.Write($"Digite a nota de {alunos[i]}: ");
        notas[i] = Console.ReadLine();
        }

        Console.WriteLine("\nResultado Final:");

        for (int i = 0; i < alunos.Length; i++)
        {
        if (Aprovado(notas[i]))
        {
         Console.WriteLine($"{alunos[i]} foi aprovado");
        }
        else
        {
        Console.WriteLine($"{alunos[i]} foi reprovado");
        }
        }
        }

    
    static bool Aprovado(string nota)
    {
        double valor = double.Parse(nota); 
        return valor >= 7;
    }
}
   
     
     
         
    
    
    

