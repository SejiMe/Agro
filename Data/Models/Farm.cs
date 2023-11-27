using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class Farm
{
    [Key, Column(TypeName = "uniqueidentifier")]
    public Guid? PK_Farm { get; set; } = Guid.NewGuid();


    [Required]
    public int AreaSQM { get; set; }
    
    public string LandCategorySoilType { get; set; }
    public string TenurialStatus { get; set; }


    [MaxLength(250), AllowNull]
    public string NorthAdjacentOwner { get; set; }
    [MaxLength(250), AllowNull]
    public string EastAdjacentOwner { get; set; }
    [MaxLength(250), AllowNull]
    public string WastAdjacentOwner { get; set; }
    [MaxLength(250), AllowNull]
    public string SouthAdjacentOwner { get; set; }

    // Who answered the application of insurance
    
    public User? FK_User { get; set; } = null!;

    [ForeignKey(nameof(Address))]
    public Address? FK_Address { get; set; }

    // Who applied for insurance
    [ForeignKey(nameof(Personal))]
    public Personal? FK_Personal { get; set; }

    public ICollection<Insurance> Insurances { get; set; }
    public ICollection<FarmCommodity> FarmCommodities { get; set; }
}
