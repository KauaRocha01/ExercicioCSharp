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
    //     string[] alunos = { "Kaua", "Sofia", "Beatriz" };

       
    //     string[] notas = new string[3];

       
    //     for (int i = 0; i < alunos.Length; i++)
    //     {
    //     Console.Write($"Digite a nota de {alunos[i]}: ");
    //     notas[i] = Console.ReadLine();
    //     }

    //     Console.WriteLine("\nResultado Final:");

    //     for (int i = 0; i < alunos.Length; i++)
    //     {
    //     if (Aprovado(notas[i]))
    //     {
    //      Console.WriteLine($"{alunos[i]} foi aprovado");
    //     }
    //     else
    //     {
    //     Console.WriteLine($"{alunos[i]} foi reprovado");
    //     }
    //     }
    //     }

    
    // static bool Aprovado(string nota)
    // {
    //     double valor = double.Parse(nota); 
    //     return valor >= 7;

    // Random random = new Random();
    // int numero = random.Next(1, 101);

    // Console.WriteLine(numero);

    // string texto = "CSharp";
    // int tamanho = texto.Length;

    // Console.WriteLine(tamanho);

    // string frase = "Olá mundo!";
    // frase = frase.Replace("mundo", "C#");

    // Console.WriteLine(frase);

    // string frase = "Estou aprendendo c#";

    // if(frase.Contains("c#"))
    // {
    //     Console.WriteLine("A frase contem 'c#'");
    // }
    // bool existe = frase.Contains("c#");
    // Console.WriteLine(frase);
    

    // int[] numeros = {1, 2, 4, 12, 8};
    // Array.Sort(numeros); // ordenando valores
    // Console.WriteLine(string.Join(", ", numeros));

    // Array.Reverse(numeros);
    // Console.WriteLine(string.Join(", ", numeros));

    // string[] nomes = {"Ana", "Bruno", "Carlos"};

    // string novoNome = "Pedro";

    // string[] novoArray = new string[nomes.Length + 1];

    // for(int i = 0; i < nomes.Length; i++)
    // {
    //     novoArray[i] = nomes[i];
    // }

    // novoArray[novoArray.Length - 1] = novoNome;
    // nomes = novoArray;

    // foreach(string nome in nomes )
    // {
    //     Console.WriteLine(nome);
    // }

    // List<string> nomes = new List<string>();

    //  nomes.Add("Ana");
    //  nomes.Add("Bruno");
    //  nomes.Add("Carlos");
    //  nomes.Add("Pedro");

    // nomes.Remove("Bruno");
    
    // foreach(string nome in nomes)
    // {
    //     Console.WriteLine(nome);
    // }

    // Console.WriteLine(nomes.Count);

    // Console.WriteLine("Digite o nome na busca: ");
    // string nomeDigitado = Console.ReadLine();

    // if(nomes.Contains(nomeDigitado))
    // {
    //     Console.WriteLine("Nome encontrado!");
    // }


    // nomes.Insert(2, "Paula");

    // nomes.RemoveAt(3);

    // foreach(string nome in nomes)
    // {
    //     Console.WriteLine(nome);
    // }
    
    // List<string> produtos = new List<string>();

    // produtos.Add("Mouse");
    // produtos.Add("Teclado");
    // produtos.Add("Monitor");

    // Console.Write("Digite o produto para remover: ");
    // string remover = Console.ReadLine();

    // if(produtos.Contains(remover))
    // {
    //     // vai remover o produto
    //     produtos.Remove(remover);
    //     foreach(string produto in produtos)
    //     {
    //         Console.WriteLine(produto);
    //     }
    // }
    // else
    // {
    //     Console.WriteLine("Produto digitado não existe na lista.");
    // }
    
    List<string> tarefas = new List<string>();
    int opcao;

    do 
    {

        Console.WriteLine("Bem vindo(a) ao menu do sistema de tarefas! :)");
        Console.WriteLine("1 - Adicionar tarefa");
        Console.WriteLine("2 - Listar tarefas");
        Console.WriteLine("3 - Remover tarefa");
        Console.WriteLine("0 - Sair");

        opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1:
                Console.Write("Digite a tarefa: ");
                tarefas.Add(Console.ReadLine());
                break;
            case 2:
                foreach(string tarefa in tarefas)
                {
                    Console.WriteLine(tarefa);
                }        
                break;
            case 3:
                Console.WriteLine("Digite a tarefa para remover: ");
                tarefas.Remove(Console.ReadLine());
                break;
            case 0:
                Console.WriteLine("Saindo....");
                Console.WriteLine("Sistema encerrado!");
                break;
            default:
                Console.WriteLine("Opção invalida!");
                break;
    
        }

    }
    while(opcao != 0);

    

    
    
    

 }
}
   
     
     
         
    
    
    

