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
    public Guid PK_Farm { get; set; } = Guid.NewGuid();


    [Required]
    public int AreaSQM { get; set; }
    
    

    [MaxLength(250), AllowNull]
    public string NorthAdjacentOwner { get; set; }
    [MaxLength(250), AllowNull]
    public string EastAdjacentOwner { get; set; }
    [MaxLength(250), AllowNull]
    public string WastAdjacentOwner { get; set; }
    [MaxLength(250), AllowNull]
    public string SouthAdjacentOwner { get; set; }

    [ForeignKey(nameof(FK_Address))]
    public Address FK_Address { get; set; }

    // Who answered the application of insurance
    [ForeignKey(nameof(User))]
    public User? FK_User { get; set; }

    // Who applied for insurance
    [ForeignKey(nameof(Personal))]
    public Personal FK_Personal { get; set; }

    public ICollection<Insurance> Insurances { get; set; }
    public ICollection<FarmCommodity> FarmCommodities { get; set; }
}
