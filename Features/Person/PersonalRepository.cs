using Agro.Data;
using Agro.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Features.Person
{
    public class PersonalRepository : IPersonalRepository
    {
        private readonly ApplicationDBContext _context;
        public PersonalRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void SubmitApplication(MembershipApplication submittedApplication)
        {
            _context.MembershipApplications.Add(submittedApplication);
        }

        public Address GetPersonalAddress(int PK_Personal)
        {
            var res = _context.PersonalAddresses
                .Where(pa => pa.FK_Personal == PK_Personal)
                .Select(pa => pa.Address)
                .Single();
            return res;
        }

        public IQueryable<Personal> GetAll()
        {
            var people = _context.Personals.AsQueryable();
            return people;
        }

        public Personal GetPerson(int id)
        {
            var person = _context.Personals
                .Where(person => person.PK_Personal == id)
                .Single();
            return person;
        }

        public Personal GetPersonByUser(Guid PK_User)
        {
            var person = _context.Personals.Where(person => person.FK_User.PK_User == PK_User).First();
            return person;
        }

        public Personal? RegisterPerson(Personal personal)
        {
            _context.Add(personal);
            var res = _context.SaveChanges();
            if(res > 0)
                return personal;
            else 
                return null;
        }

        public bool SavePerson(Personal person)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
           _context.SaveChanges();
        }

        public bool HasActiveApplication(int PK_Personal)
        {
            var res = _context.MembershipApplications
                .Any(ma => ma.FK_Personal.PK_Personal == PK_Personal && ma.Remarks == "WAITING");
            return res;
        }

        public IQueryable<MembershipApplication> GetAllApplicants()
        {
            return _context.MembershipApplications
                .Include(application => application.FK_Personal)
                .ThenInclude(person => person.FK_User);
        }

        public IQueryable<Personal> GetAllMembers()
        {
            
            return _context.Personals
                .Include(person => person.FK_User);
        }

        public bool UpdatePersonMembership(int PK_Personal, User technician, bool isApproved)
        {
           

            var updateApplicant = _context.MembershipApplications
                .Where(ma => ma.FK_Personal.PK_Personal == PK_Personal && ma.Remarks == "WAITING")
                .Include(ma => ma.FK_Personal)
                .Include(ma => ma.FK_UserApprover)
                .Single();

            updateApplicant.Remarks = isApproved ? "APPROVED" : "DENIED";
            updateApplicant.FK_UserApprover = technician;
            updateApplicant.FK_Personal.IsApproved = isApproved;
            
             _context.MembershipApplications.Update(updateApplicant);

            var res = _context.SaveChanges();


            //var resPerson = _context.Personals
            //    .Where(person => person.PK_Personal == PK_Personal)
            //    .ExecuteUpdate(p => p
            //    .SetProperty(p => p.IsApproved, isApproved));

                
                if(res > 0)
                    return true;
                else
                {
                    return false;   
                }
           
            
        }

        public bool RemoveMembership(int personID)
        {
            var applicant = GetPerson(personID);

            applicant.IsApproved = false;

            _context.Update(applicant);
            var res = _context.SaveChanges();

            if (res > 0)
                return true;
            else
                return false;
        }
    }
}
