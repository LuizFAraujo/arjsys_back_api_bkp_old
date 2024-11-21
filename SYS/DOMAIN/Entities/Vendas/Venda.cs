using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Vendas;

public class Venda : BaseEntity
{
    public DateTime DataVenda { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
}
