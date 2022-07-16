namespace DEVCar.Repositories;
using DEVCar.Models;
using DEVCar.Screens;

public static class VeiculosRepository
{
    public static IList<Veiculo> Veiculos { get; set; } = new List<Veiculo>();

    static VeiculosRepository()
    {
        Veiculos.Add(new Carro("Fusca", new DateTime(2018, 01, 01), "placa1", 50000.00, "Azul", 2000, "Gasolina"));
        Veiculos.Add(new Moto("Yamaha", new DateTime(2018, 01, 01),"placa2", 9000.00, "Amarelo", 150));
        Veiculos.Add(new Camionete("Ranger", new DateTime(2018, 01, 01),"placa3", 150000.00, "Roxa", 3500, 5000));
        Veiculos.Add(new Triciclo("Honda", new DateTime(2018, 01, 01),"placa4", 15000.00, "Preto", 100));
    }
        public static void Verificar_Placa(string placa)
    {
        foreach (Veiculo veiculo in Veiculos)
        {
            if (veiculo.Placa == placa)
            {
                System.Console.WriteLine("");
                Console.WriteLine("Placa já cadastrada!");
                System.Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                AdicionarVeiculo.Adicionar_Veiculo();

                
            }
        }
    }
    public static void Listar()
    {
        foreach (var veiculo in Veiculos)
        {
            if(veiculo is Carro)
            {
                ((Carro)veiculo).Listar_Informacoes();
            }
            else if(veiculo is Moto)
            {
                ((Moto)veiculo).Listar_Informacoes();
            }
            else if(veiculo is Camionete)
            {
                ((Camionete)veiculo).Listar_Informacoes();
            }
            else if(veiculo is Triciclo)
            {
                ((Triciclo)veiculo).Listar_Informacoes();
            }
        }
    }


}
