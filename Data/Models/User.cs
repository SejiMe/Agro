using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

[Index(nameof(UserName), IsUnique = true)]
public class User
{
    [Key, Column(TypeName = "uniqueidentifier")]
    public Guid? PK_User { get; set; } = Guid.NewGuid();

    [MaxLength(40), Required]
    public string UserName { get; set; }

    [MaxLength(128), Required]
    public string Password { get; set; }

    [MaxLength(128), AllowNull]
    public string Email { get; set; }

    [MaxLength(128), Required]
    public string Salt { get; set; }

    [MaxLength(25)]
    public string Role { get; set; }

    public ICollection<MembershipApplication> Applications { get; set; }

}
