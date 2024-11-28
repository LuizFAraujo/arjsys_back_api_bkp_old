using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Pessoas;

public class Pessoa : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public string Setor { get; set; } = string.Empty;
    public string Funcao { get; set; } = string.Empty;
}
