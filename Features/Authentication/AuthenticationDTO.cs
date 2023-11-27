using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Authentication
{
    public class AuthenticationDTO
    {
        public Guid? PK_User { get; set; }
        public string? username { get; set; }
        public string? role { get; set; }
        public string? email { get; set; }
        public DateTime TimeLogged { get; set; }

        public AuthenticationDTO(Guid? userID, string username, string role, string email, DateTime timeLogged)
        {
            PK_User = userID;
            this.username = username;
            this.role = role;
            this.email = email;
            TimeLogged = timeLogged;
        }
    }
}
