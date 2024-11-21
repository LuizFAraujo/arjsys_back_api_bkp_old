using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Almoxarifado;

public class MovimentacaoEstoque : BaseEntity
{
    public int MateriaPrimaId { get; set; }
    public MateriaPrima MateriaPrima { get; set; } = default!;
    public int Quantidade { get; set; }
    public DateTime DataMovimentacao { get; set; }
    public string TipoMovimentacao { get; set; } = string.Empty; // Entrada ou Saída
}
