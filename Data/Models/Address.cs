
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class Address
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PK_Address { get; set; }

    [MaxLength(25), AllowNull]
    public string LotNumber { get; set; }

    [MaxLength(25), AllowNull]
    public string HouseNumber { get; set; }
    [MaxLength(70), AllowNull]
    public string Street { get; set; }
     
    [MaxLength(50)]
    public string Barangay { get; set; }

    [MaxLength(50), Required]
    public string Municipality { get; set; } = "BUNAWAN";

    [MaxLength(50), Required]
    public string Province { get; set; } = "AGUSAN DEL SUR";
    [MaxLength(60), Required]
    public string Region { get; set; } = "XIII";

    // Address can have multiple person living in them
    public ICollection<PersonalAddress> FK_PersonalAddresses { get; set; }
    
}
