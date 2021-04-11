using System;
using View;


namespace Veiculo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("-----Locação do Veiculo LTDA -------");
            int opt = 0;
            do
            {
                Console.WriteLine("\n*** Informe a opção desejada ***");
                Console.WriteLine("\n1 - Cadastro de  Cliente");
                Console.WriteLine("\n2 - Consultar Cliente");
                Console.WriteLine("\n3 - Listar os Clientes");
                Console.WriteLine("\n4 - Cadastro Veículo");
                Console.WriteLine("\n5 - Consultar Veículo");
                Console.WriteLine("\n6 - Listar os Veículos");
                Console.WriteLine("\n7 - Cadastrar Locação");
                Console.WriteLine("\n8 - Consultar Locação");
                Console.WriteLine("\n9 - Listar as Locações");
                Console.WriteLine("\n0 - Sair");

                Console.WriteLine("\nDigite a opção:");
                try
                {
                    opt = Convert.ToInt32(Console.ReadLine());
                    opt = 9;
                }
                catch
                {
                    Console.WriteLine("Opção inválida!");
                }

                switch (opt)
                {                    
                    case 1:
                        ClienteView.CadastrarCliente();
                        break;
                    case 2:
                       ClienteView.ConsultarCliente();
                        break;
                    case 3:
                        ClienteView.ListarClientes();
                        break;
                    case 4:
                        VeiculoView.CadastrarVeiculo();
                        break;
                    case 5:
                        VeiculoView.ConsultarVeiculo();
                        break;
                    case 6:
                        VeiculoView.ListarVeiculos();
                        break;
                    case 7:
                        LocacaoView.CadastrarLocacao();
                        break;
                    case 8:
                        LocacaoView.ConsultarLocacao();
                        break;
                    case 9:
                        LocacaoView.ListarLocacao();
                        break;                   
                }
            } while (opt != 0);
        }

    }
}
