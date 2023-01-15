using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicle_parking_system.Models
{
    public class ParkingSystem
    {
        public DateTime HoraEntrada { get; set; } = DateTime.Now;
        public List<string> Veiculos { get; set; } = new List<string>();

        public void CadastrarVeiculo()
        {
            Console.Write("Digite a placa do veículo: ");
            string placaVeiculo = Console.ReadLine().ToUpper();
            Veiculos.Add(placaVeiculo);
            Console.WriteLine($"O veículo de placa {placaVeiculo} foi cadastrado com sucesso.");
            Console.WriteLine($"Entrada do veículo as {HoraEntrada.Hour}:{HoraEntrada.Minute}");
        }

        public void  PesquisarListaVeiculos()
        {
            Veiculos.ToList();
        }
    }
}