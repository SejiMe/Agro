using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class PersonalAddress
{
    public int FK_Personal { get; set; }
    public int FK_Address { get; set; }

    public Personal Personal { get; set; }
    public Address Address { get; set;}
}
