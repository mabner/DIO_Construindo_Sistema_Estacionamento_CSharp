using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionaFacil.Models
{
	public class Estacionamento
	{
		private decimal startingPrice = 0;
		private decimal perHourRate = 0;
		private List<string> vehicle = new List<string>();

		public Estacionamento(decimal startingPrice, decimal perHourRate)
		{
			this.startingPrice = startingPrice;
			this.perHourRate = perHourRate;
		}

		public void AddVehicle()
		{
			// TODO: Pedir para o usuário digitar uma numberPlate (ReadLine) e adicionar na lista "vehicle"
			// *IMPLEMENTE AQUI*
			Console.WriteLine("Digite a placa do veículo para estacionar:");
		}

		public void RemoveVehicle()
		{
			Console.WriteLine("Digite a placa do veículo para remover:");

			// Pedir para o usuário digitar a numberPlate e armazenar na variável numberPlate
			// *IMPLEMENTE AQUI*
			string numberPlate = "";

			// Verifica se o veículo existe
			if (vehicle.Any(x => x.ToUpper() == numberPlate.ToUpper()))
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
				Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
			}
		}

		public void ListVehicles()
		{
			// Verifica se há veículos no estacionamento
			if (vehicle.Any())
			{
				Console.WriteLine("Os veículos estacionados são:");
				// TODO: Realizar um laço de repetição, exibindo os veículos estacionados
				// *IMPLEMENTE AQUI*
			}
			else
			{
				Console.WriteLine("Não há veículos estacionados.");
			}
		}
	}
}