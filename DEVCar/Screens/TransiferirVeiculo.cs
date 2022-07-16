namespace DEVCar.Screens;
using DEVCar.Repositories;
using DEVCar.Models;

public static class TransferirVeiculo
{
    public static void Transferir()
    {
        System.Console.WriteLine("Digite a Placa do veículo que deseja Transferir: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = VeiculosRepository.Veiculos.Where(x => x.Placa == placa).FirstOrDefault()!;
        if(veiculo ==null)
        {
            System.Console.WriteLine("Veículo não encontrado!");
            Console.ReadLine();
            return;
        }
        
        System.Console.WriteLine($"Transferir Veiculo:{veiculo.Nome}");
        Console.WriteLine("Digite o CPF do comprador : ");
        string cpf = Console.ReadLine()!;
        veiculo.Cpf = cpf;

        VeiculosVendidos.VeiculosTransferidos.Add(veiculo);

        VeiculosRepository.Veiculos.Remove(veiculo);

        Console.WriteLine("Transferido com sucesso!");
        System.Console.WriteLine("O Veiculo foi transferido para a Lista de Veiculos Vendidos");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        
    }
}
