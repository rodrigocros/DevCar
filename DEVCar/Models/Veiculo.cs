namespace DEVCar.Models;
using Repositories;

public class Veiculo
{
    public Guid Chassi { get; set; } = Guid.NewGuid();
    public string Nome { get; set; }
    public DateTime DataFabricacao { get; set; }
    public string Placa { get; set; }
    public double Valor { get; set; }
    public string Cpf { get; set; } = "00000000000";
    public string Cor { get; set; }

    public Veiculo(string nome, DateTime dataFabricacao, string placa, double valor, string cor)
    {
        Nome = nome;
        DataFabricacao = dataFabricacao;
        Placa = placa;
        Valor = valor;
        Cor = cor;
    }
    public virtual void Vender_Veiculo()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine($"Qual o CPF do comprador: ");
        string CpfComprador = Console.ReadLine()!;
        Cpf = CpfComprador;
        VeiculosVendidos.VeiculosTransferidos.Add(this);
        System.Console.WriteLine("");
        System.Console.WriteLine("Veiculo vendido com sucesso!");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    public virtual void Listar_Informacoes()
    {
        System.Console.WriteLine($"Chassi: {Chassi}");
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Data de Fabricação: {DataFabricacao}");
        System.Console.WriteLine($"Placa: {Placa}");
        System.Console.WriteLine($"Valor: {Valor}");
        System.Console.WriteLine($"CPF: {Cpf}");
        System.Console.WriteLine($"Cor: {Cor}");

    }
    public virtual void Alterar_Informacoes()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine("Qual a nova cor do veiculo?");
        Cor = Console.ReadLine()!;
        System.Console.WriteLine("Qual o novo valor do veiculo?");
        Valor = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("");

        System.Console.WriteLine("Veiculo alterado com sucesso!");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();

    }
}
