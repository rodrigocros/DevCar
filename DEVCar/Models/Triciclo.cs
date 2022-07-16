namespace DEVCar.Models;
using Repositories;


class Triciclo : Veiculo
{
    public int Rodas { get {return 3;}}
    public int Potencia { get; set; }

    public Triciclo(string nome, DateTime dataFabricacao, string placa, double valor, string cor, int potencia):base(nome, dataFabricacao,placa, valor, cor)
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
        System.Console.WriteLine($"Tipo: Triciclo");
        base.Listar_Informacoes();
        System.Console.WriteLine($"Rodas: {Rodas}");
        System.Console.WriteLine($"Potencia(CV): {Potencia}");
    }
    public override void Alterar_Informacoes()
    {
        base.Alterar_Informacoes();
    }
    

}
