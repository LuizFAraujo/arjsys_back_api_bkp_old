using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Producao;

public class Producao : BaseEntity
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataTermino { get; set; }
    public string Status { get; set; } = string.Empty;
}
