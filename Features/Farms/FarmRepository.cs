using Agro.Data;
using Agro.Data.Models;
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
    public ICollection<Farm> GetFarms(int id)
    {
        var results = _context.Farms.Where(farm => farm.FK_Personal.PK_Personal == id).ToList();

        return results;
    }
}
