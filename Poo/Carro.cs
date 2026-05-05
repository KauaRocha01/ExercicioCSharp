namespace Poo
{
    public class Carro: Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        //métodos(ações que a classe pode realizar)

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}