using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Compras;

public class ItemCompra : BaseEntity
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
}
