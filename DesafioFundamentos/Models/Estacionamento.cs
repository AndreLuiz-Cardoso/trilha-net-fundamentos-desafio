using System.Diagnostics.Contracts;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Enter the license plate number to park:");
            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"Vehicle with license plate {placa} parked successfully!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Enter license plate number to remove:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                if(int.TryParse(Console.ReadLine(), out int hours))
                {
                    decimal valorTotal = precoInicial + precoPorHora * hours;
                    veiculos.Remove(placa.ToUpper());
                    Console.WriteLine($"The vehicle {placa} has been removed, and the total price is $ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Invalid input for hours. Please enter a valid numeric value.");
                }            
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please check if you entered the correct license plate.");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}