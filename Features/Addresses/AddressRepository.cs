using Agro.Data;
using Agro.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Addresses;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDBContext _context;
    public AddressRepository(ApplicationDBContext applicationDBContext)
    {
        _context = applicationDBContext;
    }

    public bool AddAddress(Address address)
    {
        _context.Addresses.Add(address);
        var res = _context.SaveChanges();
        
        if(res > 0)
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }
    
}
