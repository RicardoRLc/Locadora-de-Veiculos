using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace View
{
    public class LocacaoView
    {
        public static void ListarLocacao()
        {
            Console.WriteLine("\n===================[ LISTA LOCAÇÕES ]==================");
            List<LocacaoModels> locacoes = LocacaoController.GetLocacao();

            locacoes.ForEach(locacao => Console.WriteLine(locacao));
        }

        public static void CadastrarLocacao()
        {
            Console.WriteLine("---===[ CADASTRO DA LOCAÇÃO ]===---");
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<VeiculoModels> veiculos = VeiculoController.GetVeiculos();

            int idCliente = 0;

            Console.WriteLine("\nDigite o ID Cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());

            if (idCliente != 0)
            {
                ClienteModels cliente = clientes.Find(cliente => cliente.IdCliente == idCliente);
                LocacaoModels locacao = LocacaoController.addLocacao(cliente);

                int idVeiculo = 0;

                do
                {
                    Console.WriteLine("\nDigite o ID Veiculo: ");
                    Console.WriteLine("DIGITE ZERO (0) P/ FINALIZAR!");
                    idVeiculo = Convert.ToInt32(Console.ReadLine());

                    if (idVeiculo != 0)
                    {
                        VeiculoModels veiculo = veiculos.Find(veiculo => veiculo.IdVeiculo == idVeiculo);

                        locacao.AdicionarVeiculo(veiculo);
                    }
                } while (idVeiculo != 0);
            }            
        }

        public static void ConsultarLocacao()
        {
            Console.WriteLine("Digite o ID da Locação: ");
            int idLocacao = Convert.ToInt32(Console.ReadLine());

            try
            {
                LocacaoModels locacao =
                (from locacao1 in LocacaoController.GetLocacao()
                 where locacao1.IdLocacao == idLocacao
                 select locacao1).First();

                Console.WriteLine("\n=================[ CONSULTA LOCAÇÕES ]=================");
                Console.WriteLine(locacao.ToString());
            }
            catch
            {
                Console.WriteLine("==> LOCAÇÃO NÃO EXISTE!");
            }
        }

    }

}



