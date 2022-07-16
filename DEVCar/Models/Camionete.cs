namespace DEVCar.Models;
using Repositories;

class Camionete : Veiculo
{
    public int Portas { get; set; } = 4;
    public int Potencia { get; set; }
    public int Capacidade { get; set; }
    public string Combustivel { get; set; } = "Diesel";

    
    public Camionete(string nome, DateTime dataFabricacao, string placa, double valor, string cor, int potencia, int capacidade) : base(nome, dataFabricacao, placa, valor, cor)
    {
        Potencia = potencia;
        Capacidade = capacidade;
    }

    public override void Vender_Veiculo()
    {
        base.Vender_Veiculo();
        VeiculosRepository.Veiculos.Remove(this);
    }
    public override void Listar_Informacoes()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine($"Tipo: Camionete");
        base.Listar_Informacoes();
        System.Console.WriteLine($"Portas: {Portas}");
        System.Console.WriteLine($"Potencia(cv): {Potencia}");
        System.Console.WriteLine($"Capacidade(lt): {Capacidade}");
        System.Console.WriteLine($"Combustivel: {Combustivel}");

    }
    public override void Alterar_Informacoes()
    {
        base.Alterar_Informacoes();

    }

    
}
