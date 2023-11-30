using Agro.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Addresses;

public interface IAddressRepository
{
    bool AddAddress(Address address);

    bool UpdateAddress(Address address);

    void Save();

}
