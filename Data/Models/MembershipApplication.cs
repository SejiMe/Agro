using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Data.Models
{
    public class MembershipApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK_MembershipApplication { get; set; }

        public DateTime DateApplied { get; set; } = DateTime.Now;

        [AllowedValues(["APPROVED", "DENIED", "WAITING"])]
        public string? Remarks { get; set; } = "WAITING";

        [Column("FK_UserApprover")]
        public User? FK_UserApprover { get; set; }
        
        [Column("FK_Personal")]
        public Personal FK_Personal  { get; set; }
    }
}
