using SYS.DOMAIN.Entities.Almoxarifado;

namespace SYS.DOMAIN.Interfaces;

public interface IMateriaPrimaRepository
{
    Task<IEnumerable<MateriaPrima>> GetAllAsync();
    Task<MateriaPrima> GetByIdAsync(int id);
    Task AddAsync(MateriaPrima materiaPrima);
    Task UpdateAsync(MateriaPrima materiaPrima);
    Task DeleteAsync(int id);
}
