using Agro.Data;
using Agro.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Farms;

public class FarmRepository : IFarmRepository
{
    private readonly ApplicationDBContext _context;

    public FarmRepository(ApplicationDBContext context)
    {
        _context = context;
    }


    public Task<bool> CreateInitialFarms(Personal owner)
    {
        var task = Task.Run(async () => {

            _context.Farms.Add(new Farm { CommodityName = "Rice", isHVCDP = false, FK_Personal = owner, FK_Address = new Address() });
            _context.Farms.Add(new Farm { CommodityName = "Corn", isHVCDP = false, FK_Personal = owner, FK_Address = new Address() });
            _context.Farms.Add(new Farm { CommodityName = "", isHVCDP = true, FK_Personal = owner, FK_Address = new Address() });

            var address = _context.Addresses.Add(new Address());
            _context.PersonalAddresses.Add(new PersonalAddress() { FK_Address = address.Entity.PK_Address ,Address = address.Entity, Personal = owner,  FK_Personal = owner.PK_Personal});
            return await _context.SaveChangesAsync();
        });

        var res = task.Result > 0;
        return Task.FromResult(res);
    }

    public Task<IEnumerable<Farm>> GetAllFarm(int owner)
    {
        var task = Task.Run(() =>
        {
            return _context.Farms
            .Include(farm => farm.FK_Address)
            .Include(farm => farm.FK_Personal)
            .Include(farm => farm.FK_User)
            .Where(farm => farm.FK_Personal.PK_Personal == owner)
            .OrderBy(farm => farm.CommodityName)
            .AsEnumerable();
        });
        
        return task;
    }

    public Farm GetFarm(int owner, string commodityName)
    {
        var res = _context.Farms
            .Where(farm => farm.FK_Personal.PK_Personal == owner)
            .Include(farm => farm.FK_Address)
            .Where(f => f.CommodityName == commodityName)
            .Single() ;

        return res;
    }

    public Address GetFarmAddress(Guid PK_Farm)
    {
        var res = _context.Farms
            .Where(farm => farm.PK_Farm == PK_Farm)
            .Select(farm => farm.FK_Address)
            .Single();

        return res;
    }

    public Task<bool> HasFarm(int Pk_person)
    {
        var task = Task.Run(async () =>
        {
            return _context.Farms.Any(f => f.FK_Personal.PK_Personal == Pk_person);
        });
        
        return task;
    }
}
