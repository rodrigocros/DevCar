namespace DEVCar.Screens;
using DEVCar.Repositories;
using DEVCar.Models;

public static class MenuInicial
{
    enum Menu
    {
        Adicionar_Veiculo = 1,
        Listar_Veiculo = 2,
        Historico_Veiculo = 3,
        Sair = 0,
    }
    public static void Iniciar()
    {
        Boolean sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Veiculo");
            Console.WriteLine("2 - Listar Veiculos Disponíveis");
            Console.WriteLine("3 - Historico de Veiculos Vendidos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Digite a opção desejada: ");
            
            int opcao = int.Parse(Console.ReadLine()!);
            Menu escolha = (Menu)opcao;
            
            Console.Clear();
            switch (escolha)
            {
                case Menu.Adicionar_Veiculo:
                    AdicionarVeiculo.Adicionar_Veiculo();
                    break;
                case Menu.Listar_Veiculo:
                    ListarVeiculos.IniciarListagem();
                    break;
                case Menu.Historico_Veiculo:
                    Historico_Veiculo.IniciarHistorico();
                    break;
                case Menu.Sair:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

    }
}