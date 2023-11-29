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


    public IQueryable<FarmCommodity> GetFarms(int id)
    {
        var results = _context.FarmCommodities
            .Include(fc => fc.Farm)
                .ThenInclude(farm => farm.FK_Personal)
            .Include(fc => fc.Commodity)
            .Where(fc => fc.Farm.FK_Personal.PK_Personal == id);

        return results;
    }
}
