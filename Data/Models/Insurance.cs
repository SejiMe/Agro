using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models;

public class Insurance
{
    [Key]
    public Guid PK_Insurance { get; set; } = Guid.NewGuid();

    // W for waiting
    public bool Remarks { get; set; } = false;
    [MaxLength(15)]
    public string Status { get; set; } = "WAITING";
    public DateTime DateApplied { get; set; } = DateTime.Now;

    [AllowNull]
    public DateTime DateModified { get; set; }

    [Column("FK_Farm")]
    public Farm? FK_Farm { get; set; }
    [Column("FK_User")]
    public User? FK_User { get; set; } = null!;
}
