using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicle_parking_system.Models
{
    public class ParkingSystem
    {
        public List<string> Veiculos { get; set; } = new List<string>();
        public bool Menu { get; set; }

        public void CadastrarVeiculo()
        {
            Console.WriteLine("======= ENTRADA VEÍCULO =======");
            Console.WriteLine("===============================");
            Console.Write("Digite a placa do veículo: ");
            string placaVeiculo = Console.ReadLine().ToUpper();
            Veiculos.Add(placaVeiculo);
            Console.WriteLine($"O veículo de placa {placaVeiculo} foi cadastrado com sucesso.");
            Console.WriteLine("===============================");
        }

        public void PesquisarListaVeiculos()
        {
            Console.WriteLine("VeÍculos estacionados: ");
            Console.WriteLine("===============================");
            Veiculos.ToList();
            foreach (string placa in Veiculos)
            {
                Console.WriteLine($"Placa: {placa}");
            }
            Console.WriteLine("===============================");
        }

        public void Pagamento()
        {
            Console.WriteLine("======= SAÍDA VEÍCULO =======");
            Console.WriteLine("===============================");
            Console.Write("Digite a placa do veículo: ");
            string placaVeiculoSaida = Console.ReadLine().ToUpper();
            Console.Write("Digite o tempo estacionado: ");
            int tempoPermanencia = int.Parse(Console.ReadLine());

            int totalPagamento = 5 * tempoPermanencia;

            Console.WriteLine("===============================");
            Console.WriteLine($"Pagamento total R$: {totalPagamento},00");
            Console.WriteLine($"O veiculo de placa: {placaVeiculoSaida} pode ser liberado.");
            Console.WriteLine("===============================");
            Veiculos.Remove(placaVeiculoSaida);
        }

        public bool EncerrarSistema(bool alterarMenu)
        {
            Console.WriteLine("====== SISTEMA ENCERRADO. ======");
            Console.WriteLine("================================");
            return Menu = alterarMenu = false;
        }
    }
}