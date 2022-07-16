namespace DEVCar.Screens;
using DEVCar.Repositories;
using DEVCar.Models;

public static class Historico_Veiculo
{
    public static void IniciarHistorico()
    {
        Console.WriteLine("Histórico de Veículos Vendidos");
        Console.WriteLine("");
        VeiculosVendidos.Listar();
        Console.WriteLine("");
        System.Console.WriteLine("Escolha uma opção:");
        System.Console.WriteLine("1 - Veiculo de maior Valor ");
        System.Console.WriteLine("2 - Veiculo de menor Valor ");
        int escolha = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("");
        System.Console.WriteLine("Processando...");
        switch (escolha)
        {
            case 1:
                VeiculosVendidos.Veiculo_Valor_Maior();
                break;
            case 2:
                VeiculosVendidos.Veiculo_Valor_Menor();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

    }
}
