namespace DEVCar.Repositories;
using DEVCar.Models;

public static class VeiculosVendidos
{
    public static IList<Veiculo> VeiculosTransferidos { get; set; } = new List<Veiculo>();
    static VeiculosVendidos()
    {
        // VeiculosTransferidos.Add(new Carro("triton", new DateTime(2018, 01, 01), "placa1", 1600.00, "Azul", 2000, "Gasolina"));
        // VeiculosTransferidos.Add(new Carro("triton", new DateTime(2018, 01, 01), "placa1", 30.00, "Azul", 2000, "Gasolina"));
        // VeiculosTransferidos.Add(new Carro("triton", new DateTime(2018, 01, 01), "placa1", 7000.00, "Azul", 2000, "Gasolina"));
        // VeiculosTransferidos.Add(new Carro("triton", new DateTime(2018, 01, 01), "placa1", 15000.00, "Azul", 2000, "Gasolina"));
    }

    public static void Listar()
    {
        foreach (var veiculo in VeiculosTransferidos)
        {
            if (veiculo is Carro)
            {
                ((Carro)veiculo).Listar_Informacoes();
            }
            else if (veiculo is Moto)
            {
                ((Moto)veiculo).Listar_Informacoes();
            }
            else if (veiculo is Camionete)
            {
                ((Camionete)veiculo).Listar_Informacoes();
            }
            else if(veiculo is Triciclo)
            {
                ((Triciclo)veiculo).Listar_Informacoes();
            }
        }
    }
    public static void Veiculo_Valor_Maior()
    {
        Veiculo veiculo = VeiculosTransferidos.OrderByDescending(x => x.Valor).FirstOrDefault()!;
        Texto_Veiculo_Maior();

        veiculo.Listar_Informacoes();
        System.Console.WriteLine("");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    public static void Veiculo_Valor_Menor()
    {
        Veiculo veiculo = VeiculosTransferidos.OrderBy(x => x.Valor).FirstOrDefault()!;
        Texto_Veiculo_Maior();
        
        veiculo.Listar_Informacoes();
        System.Console.WriteLine("");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    private static void Texto_Veiculo_Maior()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine("O veiculo mais caro é: ");
    }
    private static void Texto_Veiculo_Menor()
    {
        System.Console.WriteLine("============================");
        System.Console.WriteLine("");
        System.Console.WriteLine("O veiculo mais barato é: ");
    }
}
