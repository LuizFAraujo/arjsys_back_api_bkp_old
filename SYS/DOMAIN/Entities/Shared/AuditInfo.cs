namespace SYS.DOMAIN.Entities.Shared;

public class AuditInfo : BaseEntity
{
    public string CriadoPor { get; set; } = string.Empty;
    public string? AlteradoPor { get; set; }
}
