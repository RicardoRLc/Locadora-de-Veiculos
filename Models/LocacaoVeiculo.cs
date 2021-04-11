
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}