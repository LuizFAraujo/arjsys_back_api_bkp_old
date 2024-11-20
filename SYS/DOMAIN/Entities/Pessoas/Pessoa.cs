using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Pessoas;

public class Pessoa : BaseEntity
{
    public string Nome { get; set; }
    public string Setor { get; set; }
    public string Funcao { get; set; }
}
