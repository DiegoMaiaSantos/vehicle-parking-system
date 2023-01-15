using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vehicle_parking_system.Models
{
    public class ParkingSystem
    {
        public string TamanhoVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public List<string> VeiculosCadastrados { get; set; } = new List<string>();

        public ParkingSystem(string tamanhoVeiculo,
                             string placaVeiculo)
        {
            tamanhoVeiculo = TamanhoVeiculo;
            placaVeiculo = PlacaVeiculo;
        }
    }
}