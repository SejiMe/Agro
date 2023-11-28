using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class Personal
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PK_Personal { get; set; }

    [MaxLength(150), Required]
    public string FirstName { get; set; }
    [MaxLength(150), Required]
    public string LastName { get; set; }


    [AllowNull, MaxLength(150)]
    public string? MiddleName { get; set; }
    [AllowNull, MaxLength(6)]
    public string? Suffix { get; set; }
    public char? Gender { get; set; }

    [AllowNull]
    public string? SpouseName { get; set; } = string.Empty;

    [MaxLength(30)]
    public string? civil_status { get; set; } = "Single";

    [Required]
    public bool IsApproved { get; set; } = false;

    [AllowNull]
    public string? Association { get; set; } = string.Empty;

    [Column(TypeName = "varbinary(max)")]
    public byte[]? Image { get; set; }

    [AllowNull, MaxLength(14)]
    public string? ContactNumber { get; set; }

    [Column("FK_User")]
    public User FK_User { get; set; }

    // This person can have as many insurance they can have
    public ICollection<Insurance> Insurances { get; set; }

    // Personal Class can have more than 1 assigned address but will pick the first one
    public ICollection<PersonalAddress> FK_PersonalAddress { get; set; }
}
