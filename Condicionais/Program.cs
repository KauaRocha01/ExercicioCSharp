namespace Condicionais;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // int numero = 6;

        // if(numero >0){
        //     Console.WriteLine("Numero positivo");
        // }else{

        // }

        //     Console.WriteLine("Numero negativo");

        // Console.WriteLine("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero > 0)
        // {
        // Console.WriteLine("Positivo");
        // }
        // else if (numero == 0){
        // Console.WriteLine("O número é zero");
        // }
        // else{
        //     Console.WriteLine("Negativo");
        // }

        // Console.WriteLine("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade < 16)
        // {
        //     Console.WriteLine("Não pode votar.");
        // }
        // else if(idade < 18)
        // {
        //     Console.WriteLine("Voto opcional");
        // }
        // else
        // {
        //     Console.WriteLine("Voto obrigatorio");
        // }

//         Console.Write("Digite a nota: ");
// double nota = double.Parse(Console.ReadLine());

// if (nota >= 7)
// {
//     Console.WriteLine("Aprovado!");

//     if (nota >= 9)
//     {
//         Console.WriteLine("Aprovado e ganhou uma estrelinha!");
//     }
// }
// else if (nota >= 5)
// {
//     Console.WriteLine("Recuperação");
// }
// else
// {
//     Console.WriteLine("Reprovação");
// }
            
            // int n1 = 25;
            // int n2 = 5;

            // if(n1 > n2)
            // {
            //     Console.WriteLine("Primeiero(n1) é maior");
            // }
            // else if(n2 > n1)
            // {
            //     Console.WriteLine("Segundo(n2) é maior");
            // }
            // else 
            // {
            //     Console.WriteLine("Número iguais"); 
            // }

            // Console.Write("Usuario: ");
            // string usuario = Console.ReadLine();

            // Console.Write("Senha: ");
            // string senha = Console.ReadLine();

            // if(usuario == "admim" && senha == "1234")
            // {
            //     Console.WriteLine("Acesso permitido.");
            // }
            // else 
            // {
            //     Console.WriteLine("Acesso negado");
            // }

            // int idade = 18;
            // Console.WriteLine(idade >= 18 ? "Maior de idade": "Menor de idade");

        //     Console.Write("Digite um número de 1 a 3: ");
        //     int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        //     {
        //     case 1:
        //         Console.WriteLine("Você esolheu a opção 1.");
        //         break;
        //     case 2:
        //         Console.WriteLine("Você escolheu a opção 2.");
        //         break;
        //     case 3:
        //         Console.WriteLine("Você escolheu a opção 3.");
        //         break;
        //     default:
        //         Console.WriteLine("Opção invalida!");
        //         break;            
        //     }

        Console.WriteLine("Digite uma opção: (A, B ou C): ");
        string opcao = Console.ReadLine().ToUpper();

        switch(opcao)
        {
            case "A":
                Console.WriteLine("Você escolheu a opção A.");
                break;
            case "B":
                Console.WriteLine("Você escolheu a opção B.");    
                break;
            case "C":
                Console.WriteLine("Você escolheu a opção C.");
                break;
            default:
                Console.WriteLine("Opção invalida");        
                break;

        }
          
             
    

    }
    }

