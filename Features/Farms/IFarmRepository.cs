using Agro.Data.Models;

namespace Agro.Features.Farms;

public interface IFarmRepository
{
    ICollection<Farm> GetFarms(int id);

    IQueryable GetFarmCommodity(int id);
}