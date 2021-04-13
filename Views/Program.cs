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
                Console.WriteLine("\n3 - Lista  Cliente");
                Console.WriteLine("\n4 - Atualiza Cliente");
                Console.WriteLine("\n5 - Deleta Clientes");
                Console.WriteLine("\n6 - Cadastro Veículo");
                Console.WriteLine("\n7 - Consultar Veículo");
                Console.WriteLine("\n8 - Listar os Veículos");
                Console.WriteLine("\n9- Cadastrar Locação");
                Console.WriteLine("\n10 - Consultar Locação");
                Console.WriteLine("\n11 - Listar as Locações");
                Console.WriteLine("\n0 - Sair");

                Console.WriteLine("\nDigite a opção:");
                try
                {
                    opt = Convert.ToInt32(Console.ReadLine());
                    opt = 11;
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
                        ClienteView.AtualizaCliente();
                        break;        
                    case 5:
                        ClienteView.DeletaClientes();
                        break;
                    case 6:
                        VeiculoView.CadastrarVeiculo();
                        break;
                    case 7:
                        VeiculoView.ConsultarVeiculo();
                        break;
                    case 8:
                        VeiculoView.ListarVeiculos();
                        break;
                    case 9:
                        LocacaoView.CadastrarLocacao();
                        break;
                    case 10:
                        LocacaoView.ConsultarLocacao();
                        break;
                    case 11:
                        LocacaoView.ListarLocacao();
                        break;                   
                }
            } while (opt != 0);
        }

    }
}
