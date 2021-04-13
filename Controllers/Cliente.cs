using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public static class ClienteController
    {
        public static void CadastrarCliente(
            string nomeCliente,
            string dataNascimento,
            string cpfCliente,
            int diasDevolucao
        )
        {
            DateTime dtNasc;
            try
            {
                dtNasc = Convert.ToDateTime(dataNascimento);
            }
            catch
            {
                Console.WriteLine("Formato inválido!");
                dtNasc = DateTime.Now;
            }

            new ClienteModels(
                nomeCliente,
                dataNascimento,
                cpfCliente,
                diasDevolucao
            );
        }

        public static void AtualizarCliente(
            int IdCliente,
            string nomeCliente,
            string dataNascimento,
            string cpfCliente,
            int diasDevolucao)

        {
            DateTime dataNascimento;

            try
            {
                dataNascimento = Convert.ToDateTime(dataNascimento);
            }
            catch
            {
                throw new Exception("Data inválida");
            }
            if (nomeCliente.Length == 0)
            {
                throw new Exception("Digite um nome válido");
            }
            Cliente.AtualizarCliente(idCliente, nomeCliente, dataNascimento, cpfCliente, diasDevolucao);
        }

        public  ClienteController GetCliente(int idCliente)
        {
            return ClienteController.GetCliente(idCliente);
        }
        public static List<ClienteModels> GetClientes()
        {
            return ClienteModels.GetClientes();
        }
        
    }
}