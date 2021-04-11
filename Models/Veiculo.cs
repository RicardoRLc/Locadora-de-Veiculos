using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DbRepository;
using System.Linq;

namespace Models
{
    public class VeiculoModels
    {
        [Key]
        public int IdVeiculo { set; get; }
        public string Marca { set; get; } // marca
        public string Modelo { set; get; } // Modelo
        public int Ano { set; get; } // ano
        public double ValorLocacaoVeiculo { set; get; } // preço
        public int EstoqueVeiculo { set; get; }
        public int VeiculoLocado { set; get; }
        public List<LocacaoModels> locacoes = new List<LocacaoModels>();

        public VeiculoModels(
            string marca,
            string modelo,
            int ano,
            double valorLocacaoVeiculo,
            int estoqueVeiculo
        )
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            ValorLocacaoVeiculo = valorLocacaoVeiculo;
            EstoqueVeiculo = estoqueVeiculo;
            VeiculoLocado = 0;

            var db = new Context();
            db.Veiculos.Add(this);
            db.SaveChanges();
        }

        public VeiculoModels()
        {

        }

        public static VeiculoModels GetVeiculo(int idVeiculo)
        {
            var db = new Context();
            return (from veiculo in db.Veiculos
                    where veiculo.IdVeiculo == idVeiculo
                    select veiculo).First();
        }

        public override string ToString()
        {
            var db = new Context();

            // Included method number of movies in rent
            int qtdVeiculo = (
                from veiculo in db.LocacaoVeiculo
                where veiculo.IdVeiculo == IdVeiculo
                select veiculo
                ).Count();

           return $"--------------------===[ VEICULO ]===--------------------\n" +
                    $"--> Nº ID DO VEICULO: {IdVeiculo}\n" +
                    $"-> MARCA: {Marca}\n" +
                    $"-> MODELO: {Modelo}\n" +
                    $"-> ANO: {Ano}\n" +
                    $"-> VALOR DA LOCAÇÃO: {ValorLocacaoVeiculo.ToString("C")}\n" +
                    $"-> QTDE EM ESTOQUE: {EstoqueVeiculo}\n" +
                    $"-> QTDE DE LOCAÇÕES REALIZADAS: {qtdVeiculo}\n" +
                    $"-----------------------------------------------------\n";     
        }
      
        public void AtribuirLocacao(LocacaoModels locacao)
        {
            locacoes.Add(locacao); 
        }

        public static List<VeiculoModels> GetVeiculos()
        {
            var db = new Context();
            return db.Veiculos.ToList();
        }
    }
}