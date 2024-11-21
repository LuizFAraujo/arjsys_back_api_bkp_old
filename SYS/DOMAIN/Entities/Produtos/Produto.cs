using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Produtos;

public class Produto : BaseEntity
{
    public string Codigo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string MateriaPrima { get; set; } = string.Empty;
}
