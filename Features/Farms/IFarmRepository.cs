using Agro.Data.Models;

namespace Agro.Features.Farms;

public interface IFarmRepository
{
    

    IQueryable<FarmCommodity> GetFarms(int id);
}