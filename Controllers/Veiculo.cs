using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class VeiculoController
    {
        public static void CadastrarVeiculo(
            string marca,
            string modelo,
            int ano,
            double valorLocacaoVeiculo,
            int estoqueVeiculo
        )
        {
           new VeiculoModels(
              marca,
              modelo,
              Convert.ToInt32(ano),
              Convert.ToDouble(valorLocacaoVeiculo),
              estoqueVeiculo
          );

        }

        public static List<VeiculoModels> GetVeiculos()
        {
            return VeiculoModels.GetVeiculos();
        } 
    }        
}