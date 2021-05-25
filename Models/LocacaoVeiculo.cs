using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbRepository;

namespace Models
{
    public class LocacaoVeiculoModels
    {
        [Key]
        public int Id { set; get; }

        [ForeignKey("locacoes")]
        public int IdLocacao { set; get; }
        public virtual LocacaoModels Locacao {set; get;}
        [ForeignKey("veiculos")]
        public int IdVeiculo { set; get; }
        public virtual VeiculoModels Veiculo {set; get;}

        public static List<LocacaoVeiculoModels> GetLocacoesByVeiculo(int IdVeiculo)
        {
            var db = new Context();
            return (from locacao in db.LocacaoVeiculo
                    where locacao.IdVeiculo == IdVeiculo
                    select locacao).ToList();
        }
    }
}