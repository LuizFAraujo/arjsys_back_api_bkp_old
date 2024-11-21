using SYS.DOMAIN.Entities.Shared;

namespace SYS.DOMAIN.Entities.Almoxarifado;

public class Almoxarifado : BaseEntity
{
    public string NomeItem { get; set; } = string.Empty;
    public int Quantidade { get; set; }
}
