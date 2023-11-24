using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class Commodity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PK_Commodity { get; set; }

    [MaxLength(50)]
    public string Description { get; set; }

    [MaxLength(25)]
    public string Tag { get; set; }

    public ICollection<FarmCommodity> FarmCommodities { get; set; }
}
