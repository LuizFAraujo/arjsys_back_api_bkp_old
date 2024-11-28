using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Produtos;

public class TipoProduto : BaseEntity
{
    public string Descricao { get; set; } = string.Empty;
}
