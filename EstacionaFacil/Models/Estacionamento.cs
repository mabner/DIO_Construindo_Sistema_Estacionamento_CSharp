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
            var numberPlate = Console.ReadLine();
            if (numberPlate != null) _vehicle.Add(numberPlate);
            Console.WriteLine($"Veículo {numberPlate} estacionado na vaga {_vehicle.Count}");
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a numberPlate e armazenar na variável numberPlate
            // *IMPLEMENTE AQUI*
            string numberPlate = "";

            // Check if the vehicle exists
            if (_vehicle.Any(x => x.ToUpper() == numberPlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "startingPrice + perHourRate * horas" para a variável valorTotal
                // *IMPLEMENTE AQUI*
                int hours = 0;
                decimal totalPrice = 0;

                // TODO: Remover a numberPlate digitada da lista de veículos
                // *IMPLEMENTE AQUI*

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
            int parkingSlot = 1;
            if (_vehicle.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in _vehicle)
                {
                    Console.WriteLine($"Vaga {parkingSlot}: {item}");
                    parkingSlot++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}