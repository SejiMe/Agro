using Agro.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Person
{
    public interface IPersonalRepository
    {
        IQueryable<Personal> GetAll();
        
        IQueryable<MembershipApplication> GetAllApplicants();
        
        IQueryable<Personal> GetAllMembers();

        void SubmitApplication(MembershipApplication application);

        bool HasActiveApplication(int PK_Personal);

        void Save();
        
        Personal GetPerson(int id);

        Address GetPersonalAddress(int id);
        
        Personal GetPersonByUser(Guid PK_User);

        Personal RegisterPerson(Personal personal);
       
        bool SavePerson(Personal person);

         bool RemoveMembership(int personID);

        bool UpdatePersonMembership(int PK_Personal, User approver, bool isApproved);
    }
}
