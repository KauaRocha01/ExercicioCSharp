namespace Poo
{
    public class Veiculo
    {
        public string Marca;
        public int Ano;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Veiculo: {Marca}, Ano: {Ano}");
        }
        
   
    }
}