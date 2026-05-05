namespace Poo;

class Program
{
    static void Main(string[] args)
    {
        // instanciando o objeto da clase carro
        Carro meuCarro = new Carro();

        //Definando valores para os atributos
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2022;

        meuCarro.ExibirInformacoes();

        // instanciando objeto moto

        Moto minhaMoto = new moto();

        minhaMoto.Marca = "Honda";
        minhaMoto.Ano = 2021;
        minhaMoto.TemPartidaEletrica = true;

        minhaMoto.ExibirDetalhesMoto;
    }
}
