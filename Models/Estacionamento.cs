using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string?> veiculosList = new List<string?>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            veiculosList.Add(Console.ReadLine().ToUpper());
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que quer remover");
            string? placa = Console.ReadLine().ToUpper();
            if (veiculosList.Any(x => x == placa))
            {
                veiculosList.Remove(placa);
                Console.WriteLine("Digite em horas quanto tempo o veículo permaneceu: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora*horas;
                Console.WriteLine($"\n O veículo de placa {placa} foi removido e o valor total é R${valorTotal}");
            }
            else
            {
                Console.WriteLine("O veículo não está no sistema, verifique se a placa está correta.");
            }
        }
        public void ListarVeiculos()
        {
            for(int count = 0; count != veiculosList.Count; count++)
            {
                Console.WriteLine(veiculosList[count]);
            }
            if (!veiculosList.Any())
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }
    }
}