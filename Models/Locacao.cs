using System;
using System.Linq;
using Controllers;
using DbRepository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{

    public class LocacaoModels
    {
        [Key]
        public int IdLocacao { set; get; }
        public ClienteModels Cliente { set; get; }
        [ForeignKey("clientes")]
        public int IdCliente { set; get; }
        public DateTime DataLocacao { set; get; }

        public List<VeiculoModels> veiculos = new List<VeiculoModels>();

        public LocacaoModels(
            ClienteModels cliente,
            DateTime dataLocacao
            )

        {
            IdCliente = cliente.IdCliente;
            DataLocacao = dataLocacao;
            veiculos = new List<VeiculoModels>();
            cliente.AdicionarLocacao(this);

            var db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();
        }

        public LocacaoModels()
        {

        }

        public void AdicionarVeiculo(VeiculoModels veiculo)
        {
            var db = new Context();
            LocacaoVeiculoModels locacaoVeiculo = new LocacaoVeiculoModels()
            {
                IdVeiculo = veiculo.IdVeiculo,
                IdLocacao = IdLocacao
            };

            db.LocacaoVeiculo.Add(locacaoVeiculo);
            db.SaveChanges();
        }
        
        public override string ToString()
        {
            var db = new Context();

            IEnumerable<int> veiculos = 
            from veiculo in db.LocacaoVeiculo
            where veiculo.IdLocacao == IdLocacao
            select veiculo.IdVeiculo;
            
            ClienteModels cliente = ClienteModels.GetCliente(IdCliente);

            string retorno = cliente +
                $"\n----------------===[ DADOS LOCAÇÃO ]===----------------\n" +
                $"-> DATA DE LOCAÇÃO: {DataLocacao.ToString("dd/MM/yyyy")}\n" +
                $"-> DATA DE DEVOLUÇÃO: {LocacaoController.CalculoDataDevolucao(DataLocacao, cliente).ToString("dd/MM/yyyy")}\n" +
                $"-> QTDE TOTAL DE VEICULOS: {veiculos.Count()}\n";

                double ValorTotal = 0;
                string strVeiculos = "";
                         
            if (veiculos.Count() > 0)
            {
                foreach (int id in veiculos)
                {
                    VeiculoModels veiculo = VeiculoModels.GetVeiculo(id);
                    strVeiculos += veiculo;
                    ValorTotal += veiculo.ValorLocacaoVeiculo;
                }
            }
            else
            {
               strVeiculos += "NAO HÁ VEICULOS!";
            }

            retorno += $"-> PREÇO TOTAL DAS LOCAÇÕES: R$ {ValorTotal.ToString("C2")}\n" +
            $"-------------------------------------------------------\n\n" +
            $"===================[ FILMES LOCADOS ]==================\n";

            return retorno + strVeiculos +

            $"=======================================================\n";

        }

        public static List<LocacaoModels> GetLocacao()
        {
           var db = new Context();
            return db.Locacoes.ToList();
        }

       public static LocacaoModels GetLocacao(int idLocacao)
       {
           var db = new Context();
            return (from locacao in db.Locacoes
                    where locacao.IdLocacao == idLocacao
                    select locacao).First();
       }

       public static List<LocacaoModels> GetLocacoesByCliente(int IdCliente)
        {
            var db = new Context();
            return (from locacao in db.Locacoes
                    where locacao.IdCliente == IdCliente
                    select locacao).ToList();
        }
    }
}
