using System.Data;
using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Digite o preço inicial: ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço por hora: ");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool verificador = true;
while(verificador)
{
    Console.Clear();
    Console.WriteLine("Digite a opção desejada: \n");
    Console.WriteLine("1 - Adicionar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar\n");
    
    switch(Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            verificador = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();
}

