using vehicle_parking_system.Models;

Console.WriteLine("============================");
Console.WriteLine("   - Escolha uma opção -   |");
Console.WriteLine("============================");
Console.WriteLine(" 1 - Entrada de veículo    |");
Console.WriteLine(" 2 - Pesquisar veículos    |");
Console.WriteLine(" 3 - Pagamento             |");
Console.WriteLine(" 4 - Encerrar              |");
Console.WriteLine("============================");
int escolhaMenu = int.Parse(Console.ReadLine());

ParkingSystem parking = new();

switch (escolhaMenu)
{
    case 1:
        escolhaMenu = 1;
        // Criar método para cadastar veículos
        parking.CadastrarVeiculo();
        break;
    case 2:
        escolhaMenu = 2;
        // Criar método para pesquisar veículos
        parking.PesquisarListaVeiculos();
        break;
    case 3:
        escolhaMenu = 3;
        // Criar método para pagar e liberar os veículos 
        break;
    case 4:
        escolhaMenu = 5;
        //Encerrar o sistema
        break;

    default:
        //Avisar que não aceita essa escolha
        break;
}