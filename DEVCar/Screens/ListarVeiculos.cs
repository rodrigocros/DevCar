namespace DEVCar.Screens;
using DEVCar.Repositories;
using DEVCar.Models;
using DEVCar.Screens;

public static class ListarVeiculos
{

    public static void IniciarListagem()
    {
        Console.WriteLine("Lista de Veículos");
        VeiculosRepository.Listar();
        Console.WriteLine("");
        System.Console.WriteLine("1 - Alterar Veiculo");
        System.Console.WriteLine("2 - Transferir Veiculo");
        System.Console.WriteLine("0 - Sair");
        System.Console.WriteLine("");
        System.Console.WriteLine("Digite a opção desejada: ");
        int opcao = int.Parse(System.Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                AlterarVeiculo.Alterar();
                break;
            case 2:
                TransferirVeiculo.Transferir();
                break;
            case 0:
                MenuInicial.Iniciar();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}