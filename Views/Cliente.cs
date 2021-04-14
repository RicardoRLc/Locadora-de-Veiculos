using System;
using Models;
using Controllers;
using System.Linq;

namespace View
{

    public class ClienteView
    {
        public static void CadastrarCliente()

        {
            Console.WriteLine("Qual o nome do CLiente: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento: ");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("Qual o seu CPF: ");
            string cpfCliente = Console.ReadLine();
            Console.WriteLine("Quantos dias para devolver: ");
            int diasDevolucao = Convert.ToInt32(Console.ReadLine());

            ClienteController.CadastrarCliente(
                nomeCliente, 
                dataNascimento, 
                cpfCliente, 
                diasDevolucao
                );
        }
            
        public static void ListarClientes()
        {
           Console.WriteLine("=================[ LISTA DE CLIENTES ]=================");
            ClienteController.GetClientes().ForEach(cliente => Console.WriteLine(cliente));
        }

        public static void ConsultarCliente()
        {
            Console.WriteLine("Digite o ID do Cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            

            try 
            {
                ClienteModels cliente =
                (from cliente1 in ClienteController.GetClientes()
                 where cliente1.IdCliente == idCliente
                 select cliente1).First();

                Console.WriteLine("=================[ CONSULTA CLIENTE ]==================");
                Console.WriteLine(cliente.ToString());
            }
            catch
            {
                Console.WriteLine("==> CLIENTE NÃO EXISTE!");
            }
            
        }
             public static void AtualizaCliente()
        {
           Console.WriteLine("=================[ Atualizando CLIENTE ]=================");
            ClienteController.GetClientes().ForEach(cliente => Console.WriteLine(cliente));
            Console.WriteLine("Digite o ID do Cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=================[ CLIENTE ATUALIZADO ]=================");

        }

             public static void DeletaCliente()
        {
           Console.WriteLine("=================[ DELETANDO CLIENTE ]=================");
            
            Console.WriteLine("Digite o ID do Cliente: ");
            string idCliente = Console.ReadLine();
            ClienteController.DeletaCliente(idCliente);
            Console.WriteLine("=================[ CLIENTE DELETADO ]=================");

        }

    }

}

