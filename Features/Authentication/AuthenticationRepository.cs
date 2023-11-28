using Agro.Data;
using Agro.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Authentication;

public class AuthenticationRepository : IAuthenticationRepository
{
    private readonly ApplicationDBContext _context;

    private DateTime LoggedIn { get; set; }
    private Guid? currentUser { get; set; }

    public AuthenticationRepository(ApplicationDBContext context)
    {
        _context = context; 
    }

    public bool FindExistingUser(string username)
    {
        return _context.Users.Any(user => user.UserName == username);
    }

    public DateTime GetTimeLloggedIn(string username)
    {
        return LoggedIn;
    }

    public User GetUser(string username)
    {
        var user = _context.Users.FirstOrDefault(user => user.UserName == username);
        return user;
    }

    public User GetUserByID(Guid id)
    {
        var user = _context.Users.FirstOrDefault(user => user.PK_User == id);
        return user;
    }

    public IQueryable<User> GetUsers()
    {
        var users = _context.Users.AsQueryable();
        return users;
    }

    public void RegisterUser(User user)
    {
        
    }

    public bool SaveUser(User user)
    {
        throw new NotImplementedException();
    }

    bool IAuthenticationRepository.RegisterUser(User user)
    {
        throw new NotImplementedException();
    }

    public bool Login(User user)
    {
      if(user == null)
            return false;

        currentUser = (Guid)user.PK_User;
        LoggedIn = DateTime.Now;
        return true;
    }

    public void Logout()
    {
        currentUser = null;
    }

    public AuthenticationDTO GetAuthenticationDetails()
    {
        if (currentUser != null)
        {
            var res = _context.Personals
                .Include(personal => personal.FK_User)
                .Where(user => user.FK_User.PK_User == currentUser)
                .First();
                
            return new AuthenticationDTO(currentUser, res.FK_User.UserName, res.FK_User.Role, res.FK_User.Email, LoggedIn, res.PK_Personal);
        }
       
        else
            return null;    
    }
}
