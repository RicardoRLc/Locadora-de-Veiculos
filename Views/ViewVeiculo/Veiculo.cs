using System;
using Models;
using Controllers;
using System.Linq;


namespace View
{
    public class VeiculoView
    {
        public static void CadastrarVeiculo()
        {
            Console.WriteLine("Qual a Marca do Veículo: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Qual o Modelo do Veículo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Qual o Ano do Veículo: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o Preço de Locação do Veículo: ");
            double valorLocacaoVeiculo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque: ");
            int estoqueVeiculo = Convert.ToInt32(Console.ReadLine());
            
           VeiculoController.CadastrarVeiculo(
                marca, 
                modelo, 
                ano, 
                valorLocacaoVeiculo, 
                estoqueVeiculo
                );

        }

        public static void ListarVeiculos()
        {
           Console.WriteLine("=====================[ LISTA DE VEICULOS ]=========================================================================================");
            VeiculoController.GetVeiculos().ForEach(veiculo => Console.WriteLine(veiculo));
        }

        public static void ConsultarVeiculo()
        {
            Console.WriteLine("Digite o ID do Veiculo: ");
            int idVeiculo = Convert.ToInt32(Console.ReadLine());

            try
            {
                VeiculoModels veiculo =
                (from veiculo1 in VeiculoController.GetVeiculos()
                 where veiculo1.IdVeiculo == idVeiculo
                 select veiculo1).First();

                Console.WriteLine("=====================[ CONSULTA VEICULOS ]=========================================================================================");
                Console.WriteLine(veiculo.ToString());
            }
            catch
            {
                Console.WriteLine("==> VEICULO NÃO EXISTE!");
            }
        }

    }
}