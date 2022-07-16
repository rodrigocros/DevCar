namespace DEVCar.Models;
using Repositories;


class Moto : Veiculo
{
    public int Rodas { get {return 2;}}
    public int Potencia { get; set; }

    public Moto(string nome, DateTime dataFabricacao, string placa, double valor, string cor, int potencia):base(nome, dataFabricacao, placa, valor, cor)
    {
        Potencia = potencia;
    }
    public override void Vender_Veiculo()
    {
        base.Vender_Veiculo();
    }
    public override void Listar_Informacoes()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine($"Tipo: Moto");
        base.Listar_Informacoes();
        System.Console.WriteLine($"Rodas: {Rodas}");
        System.Console.WriteLine($"Potencia(CV): {Potencia}");

    }
    public override void Alterar_Informacoes()
    {
        base.Alterar_Informacoes();
    }


}
