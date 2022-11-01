using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionaFacil.Models
{
    public class Estacionamento
    {
        private decimal _startingPrice = 0;
        private decimal _perHourRate = 0;
        private List<string> _vehicle = new List<string>();

        public Estacionamento(decimal startingPrice, decimal perHourRate)
        {
            this._startingPrice = startingPrice;
            this._perHourRate = perHourRate;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var numberPlate = Console.ReadLine().ToUpper();
            _vehicle.Add(numberPlate);
            Console.WriteLine($"Veículo {numberPlate} estacionado na vaga {_vehicle.IndexOf(numberPlate) + 1}");
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string numberPlate = Console.ReadLine().ToUpper();

            // Check if the vehicle exists
            if (_vehicle.Any(x => x.ToUpper() == numberPlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int hours = Convert.ToInt32(Console.ReadLine());
                decimal totalPrice = _startingPrice + (_perHourRate * hours);
                _vehicle.Remove(numberPlate);
                Console.WriteLine($"O veículo {numberPlate} foi removido e o preço total foi de: R$ {totalPrice}");
            }
            else
            {
                Console.WriteLine(
                    "Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListVehicles()
        {
            // Checks for parked vehicles
            if (_vehicle.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in _vehicle)
                {
                    Console.WriteLine($"{_vehicle.IndexOf(item) + 1}: {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}