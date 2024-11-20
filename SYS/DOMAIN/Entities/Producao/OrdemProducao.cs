using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Producao;

public class OrdemProducao : BaseEntity
{
    public int ProducaoId { get; set; }
    public Producao Producao { get; set; }
    public DateTime DataOrdem { get; set; }
    public string Observacoes { get; set; }
}
