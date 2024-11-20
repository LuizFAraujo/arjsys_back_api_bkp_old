using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Produtos;

public class Produto : BaseEntity
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public string MateriaPrima { get; set; }
}
