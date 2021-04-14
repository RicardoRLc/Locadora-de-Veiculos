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
                dtNasc,
                cpfCliente,
                diasDevolucao
            );

        }
        public static void AtualizaCliente(
                int idCliente,
                string nomeCliente,
                string sDataNascimento,
                string cpfCliente,
                int diasDevolucao)

        {
            DateTime dataNascimento;

            try
            {
                dataNascimento = Convert.ToDateTime(sDataNascimento);
            }
            catch
            {
                throw new Exception("Data inválida");
            }
            if (nomeCliente.Length == 0)
            {
                throw new Exception("Digite um nome válido");
            }

            ClienteModels.AtualizaCliente (
            idCliente, 
            nomeCliente, 
            dataNascimento, 
            cpfCliente, 
            diasDevolucao);
        }
        public static void DeletaCliente(string idCliente) 
        {
            ClienteModels.DeletaCliente(Convert.ToInt32(idCliente));
        }
        public  static ClienteModels GetCliente(int idCliente)
        {
            return ClienteModels.GetCliente(idCliente);
        }
        public static List<ClienteModels> GetClientes()
        {
            return ClienteModels.GetClientes();
        }
        
    }
}