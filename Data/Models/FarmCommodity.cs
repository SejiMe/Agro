using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class FarmCommodity
{
    public int FK_Commodity { get; set; }
    public Guid FK_Farm { get; set; }

    public Commodity Commodity { get; set; }
    public Farm Farm { get; set; }
}
