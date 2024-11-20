using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Compras;

public class Compra : BaseEntity
{
    public DateTime DataCompra { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ItemCompra> Itens { get; set; } = new List<ItemCompra>();
}

