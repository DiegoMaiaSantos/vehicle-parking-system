using vehicle_parking_system.Models;

ParkingSystem parking = new();
parking.Menu = true;

while (parking.Menu == true)
{
    Console.WriteLine("============================");
    Console.WriteLine("   - Escolha uma opção -   |");
    Console.WriteLine("============================");
    Console.WriteLine(" 1 - Entrada de veículo    |");
    Console.WriteLine(" 2 - Pesquisar veículos    |");
    Console.WriteLine(" 3 - Pagamento             |");
    Console.WriteLine(" 4 - Encerrar              |");
    Console.WriteLine("============================");
    int escolhaMenu = int.Parse(Console.ReadLine());

    switch (escolhaMenu)
    {
        case 1:
            escolhaMenu = 1;
            parking.CadastrarVeiculo();
            break;

        case 2:
            escolhaMenu = 2;
            parking.PesquisarListaVeiculos();
            break;

        case 3:
            escolhaMenu = 3;
            parking.Pagamento();
            break;

        case 4:
            escolhaMenu = 5;
            parking.EncerrarSistema(parking.Menu);
            break;

        default:
            Console.WriteLine("Não existe essa opção no menu.");
            break;
    }
}
