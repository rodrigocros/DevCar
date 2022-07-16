namespace DEVCar.Screens;
using DEVCar.Repositories;
using DEVCar.Models;
using System.Globalization;

public static class AdicionarVeiculo
{
    public static void Adicionar_Veiculo()
    {   Console.Clear();
        Console.WriteLine("Qual tipo de veiculo deseja adicionar?");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Moto");
        Console.WriteLine("3 - Triciclo");
        Console.WriteLine("4 - Caminhonete");
        Console.WriteLine("");
        Console.WriteLine("Digite a opção desejada: ");

        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                Carro();
                break;
            case 2:
                Moto();
                break;
            case 3:
                Triciclo();
                break;
            case 4:
                Caminhonete();
                break;
            default:
                Console.WriteLine("Opção inválida");
                Console.ReadLine();
                break;
        }
    }
    static void Carro()
    {
        Console.WriteLine("Digite o nome do carro: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a data de fabricação(DD/MM/YYYY) do Carro: ");
        DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
        Console.WriteLine("Digite a placa do Carro: ");
        string placa = Console.ReadLine()!;
        VeiculosRepository.Verificar_Placa(placa);
        
        Console.WriteLine("Digite o valor do carro: ");
        double valor = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a cor do carro: ");
        string cor = Console.ReadLine()!;
        System.Console.WriteLine("Digite o tipo de combustível do carro: ");
        string combustivel = Console.ReadLine()!;
        Console.WriteLine("Digite a potência do carro: ");
        int potencia = int.Parse(Console.ReadLine()!);
        
        Carro carro = new Carro(nome, dataFabricacao,placa, valor, cor, potencia, combustivel);
        VeiculosRepository.Veiculos.Add(carro);

        Console.WriteLine("Carro adicionado com sucesso!");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();

    }
    static void Moto()
    {
        
        Console.WriteLine("Digite o nome do Moto: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a data de fabricação(DD/MM/YYYY) da Moto: ");
        DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
        Console.WriteLine("Digite a placa da Moto: ");
        string placa = Console.ReadLine()!;
        VeiculosRepository.Verificar_Placa(placa);


        Console.WriteLine("Digite o valor do Moto: ");
        double valor = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a cor do Moto: ");
        string cor = Console.ReadLine()!;
        Console.WriteLine("Digite a potência(Cv) do Moto(): ");
        int potencia = int.Parse(Console.ReadLine()!);

        Moto moto = new Moto(nome, dataFabricacao,placa, valor, cor, potencia);
        VeiculosRepository.Veiculos.Add(moto);

        Console.WriteLine("Moto adicionada com sucesso!");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    
    }
    static void Triciclo()
    {
        
        Console.WriteLine("Digite o nome do Triciclo: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a data de fabricação(DD/MM/YYYY) do Triciclo: ");
        DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
        Console.WriteLine("Digite a placa do Triciclo: ");
        string placa = Console.ReadLine()!;
        VeiculosRepository.Verificar_Placa(placa);


        Console.WriteLine("Digite o valor do Triciclo: ");
        double valor = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a cor do Triciclo: ");
        string cor = Console.ReadLine()!;
        Console.WriteLine("Digite a potência(Cv) do Triciclo: ");
        int potencia = int.Parse(Console.ReadLine()!);

        Triciclo triciclo = new Triciclo(nome, dataFabricacao,placa, valor, cor, potencia);
        VeiculosRepository.Veiculos.Add(triciclo);

        Console.WriteLine("Triciclo adicionada com sucesso!");
        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    static void Caminhonete()
    {
        
        Console.WriteLine("Digite o nome da camionete: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a data de fabricação da camionete: ");
        DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
        Console.WriteLine("Digite a placa da camionete: ");
        string placa = Console.ReadLine()!;
        VeiculosRepository.Verificar_Placa(placa);


        Console.WriteLine("Digite o valor da camionete: ");
        double valor = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a cor da camionete: ");
        string cor = Console.ReadLine()!.ToUpper();

        try{
            if(cor == "ROXA")
            {
                Console.WriteLine("Digite a potência(Cv) da camionete: ");
                int potencia = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite a capacidade de peso(Lt) da camionete: ");
                int capacidadePeso = int.Parse(Console.ReadLine()!);

                Camionete camionete = new Camionete(nome, dataFabricacao,placa, valor, cor, potencia, capacidadePeso);
                VeiculosRepository.Veiculos.Add(camionete);
                
                Console.WriteLine("Caminhonete adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Cor inválida");
            }
        }
        catch(Exception e){
            Console.WriteLine("Erro: " + e.Message);
            throw new Exception("A cor da camionete deve ser 'Roxa'");
        }
        finally{
            System.Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}