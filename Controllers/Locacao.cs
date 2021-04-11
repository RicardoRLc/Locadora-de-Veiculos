using System;
using System.Collections.Generic;
using Models;


namespace Controllers
{
    public class LocacaoController
    {
        public static LocacaoModels addLocacao( ClienteModels cliente)
        {
           return new LocacaoModels(cliente, DateTime.Now); 
        }

        public static DateTime CalculoDataDevolucao(DateTime DtLocacao, ClienteModels Cliente)
        {
            return DtLocacao.AddDays(Cliente.DiasDevolucao);
        }

        public static List<LocacaoModels> GetLocacao()
        {
            return LocacaoModels.GetLocacao();
        }
    }
}