using System.Collections.Generic;
using System.Linq;
using DbRepository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LocacaoVeiculoModels
    {
        [Key] // Data Annotations - Main key
        public int Id { get; set; }
        [ForeignKey("locacoes")] // Data Annotations - Foreign Key
        public int IdLocacao { get; set; }
        public virtual LocacaoModels Locacao { get; set; }
        [ForeignKey("veiculos")] // Data Annotations - Foreign Key
        public int IdVeiculo { get; set; }
        public virtual VeiculoModels Veiculo { get; set; }
        public static List<LocacaoVeiculoModels> GetLocacoesByVeiculo(int IdVeiculo)
        {
            var db = new Context();
            return (from locacao in db.LocacaoVeiculo
                    where locacao.IdVeiculo == IdVeiculo
                    select locacao).ToList();
        }

    }
}