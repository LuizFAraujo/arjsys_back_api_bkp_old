using SYS.APPLICATION.Interfaces;
using SYS.DOMAIN.Entities.Almoxarifado;
using SYS.DOMAIN.Interfaces;

namespace SYS.APPLICATION.Services;

public class MateriaPrimaService(IMateriaPrimaRepository materiaPrimaRepository) : IMateriaPrimaService
{
    private readonly IMateriaPrimaRepository _materiaPrimaRepository = materiaPrimaRepository;

    public async Task<IEnumerable<MateriaPrima>> GetAllAsync()
    {
        return await _materiaPrimaRepository.GetAllAsync();
    }

    public async Task<MateriaPrima> GetByIdAsync(int id)
    {
        return await _materiaPrimaRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(MateriaPrima materiaPrima)
    {
        await _materiaPrimaRepository.AddAsync(materiaPrima);
    }

    public async Task UpdateAsync(MateriaPrima materiaPrima)
    {
        await _materiaPrimaRepository.UpdateAsync(materiaPrima);
    }

    public async Task DeleteAsync(int id)
    {
        await _materiaPrimaRepository.DeleteAsync(id);
    }
}
