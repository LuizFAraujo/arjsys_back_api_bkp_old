using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Produtos;

public class EstruturaProduto : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public List<Produto> Produtos { get; set; } = [];
    // public List<Produto> Produtos { get; set; } = new List<Produto>();
}
