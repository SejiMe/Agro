using Agro.Data.Models;

namespace Agro.Features.Farms;

public interface IFarmRepository
{

    Task<bool> CreateInitialFarms(Personal owner);

    Task<bool> HasFarm(int Pk_person);

    Address GetFarmAddress(Guid PK_Farm);

    Task<IEnumerable<Farm>> GetAllFarm(int owner);

}