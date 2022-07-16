namespace DEVCar.Screens;
using DEVCar.Repositories;
using DEVCar.Models;
using DEVCar.Screens;


public static class AlterarVeiculo
{
    public static void Alterar()
    {
        System.Console.WriteLine("Digite a Placa do veículo que deseja alterar: ");
        string placa = Console.ReadLine()!;
        foreach(var veiculo in VeiculosRepository.Veiculos)
        {
            if(veiculo.Placa == placa)
            {
                if(veiculo is Carro)
                {
                    ((Carro)veiculo).Alterar_Informacoes();
                }
                else if(veiculo is Moto)
                {
                    ((Moto)veiculo).Alterar_Informacoes();
                }
                else if(veiculo is Camionete)
                {
                    ((Camionete)veiculo).Alterar_Informacoes();
                }
                else if(veiculo is Triciclo)
                {
                    ((Triciclo)veiculo).Alterar_Informacoes();
                }
            }
        }

        

    }
}