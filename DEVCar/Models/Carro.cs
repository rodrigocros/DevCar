namespace DEVCar.Models;
using Repositories;

class Carro : Veiculo
{
    public int Portas { get; set; } = 4;
    public string Combustivel { get; set; }
    public int Potencia { get; set; }
    
    public Carro(string nome, DateTime dataFabricacao, string placa, double valor, string cor, int potencia, string combustivel):base(nome, dataFabricacao, placa, valor,cor)
    {
        Potencia = potencia;
        Combustivel = combustivel;
    }
    public override void Vender_Veiculo()
    {
        base.Vender_Veiculo();
    }
    public override void Listar_Informacoes()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine("Tipo: Carro");
        base.Listar_Informacoes();
        System.Console.WriteLine($"Portas: {Portas}");
        System.Console.WriteLine($"Combustível: {Combustivel}");
        System.Console.WriteLine($"Potência(CV): {Potencia}");

    }
    public override void Alterar_Informacoes()
    {
        base.Alterar_Informacoes();

    }
}

