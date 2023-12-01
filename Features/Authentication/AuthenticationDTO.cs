using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Authentication;

public sealed record AuthenticationDTO(Guid PK_User, string? username, string? role, string? email, DateTime TimeLogged, int PK_Personal);
