using Agro.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Authentication
{
    public interface IAuthenticationRepository
    {
        DateTime GetTimeLloggedIn(string username);

        IQueryable<User> GetUsers();
        
        User GetUserByID(Guid id);

        User GetUser(string username);         
        bool FindExistingUser(string username);

        bool RegisterUser(User user);

        bool SaveUser(User user);

        bool Login(User user);

        AuthenticationDTO GetAuthenticationDetails();

        void Logout();
    }
}
