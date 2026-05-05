namespace Poo
{
    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;

        public void ExibirDetalhesMoto()
        {
            ExibirDetalhes();
            Console.WriteLine($"Partida Eletrica: {TemPartidaEletrica}");
        }
    }
}