using EstacionaFacil.Models;

// Sets encoding to UTF8 to show accented letters properly
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal startingPrice = 0;
decimal perHourRate = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
									"Digite o preço inicial:");
startingPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
perHourRate = Convert.ToDecimal(Console.ReadLine());

// Instantiating the Estacionamento class, with the values from Console.ReadLine
Estacionamento es = new Estacionamento(startingPrice, perHourRate);

string option = string.Empty;
bool showMenu = true;

// Loops the menu
while (showMenu)
{
	Console.Clear();
	Console.WriteLine("Digite a sua opção:");
	Console.WriteLine("1 - Cadastrar veículo");
	Console.WriteLine("2 - Remover veículo");
	Console.WriteLine("3 - Listar veículos");
	Console.WriteLine("4 - Encerrar");

	switch (Console.ReadLine())
	{
		case "1":
			es.AddVehicle();
			break;

		case "2":
			es.RemoveVehicle();
			break;

		case "3":
			es.ListVehicles();
			break;

		case "4":
			showMenu = false;
			break;

		default:
			Console.WriteLine("Opção inválida");
			break;
	}

	Console.WriteLine("Pressione uma tecla para continuar");
	Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
