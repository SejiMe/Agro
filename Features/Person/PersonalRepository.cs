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

        public PersonalAddress GetPersonAddress(int id)
        {
            var res = _context.PersonalAddresses
                .Include(p => p.Personal)
                .Include(p => p.Address)
                .Where(p => p.FK_Personal == id)
                .First();
            return res;
        }

        public IQueryable<Personal> GetAll()
        {
            var people = _context.Personals.AsQueryable();
            return people;
        }

        public Personal GetPerson(int id)
        {
            var person = _context.Personals.Where(person => person.PK_Personal == id).First();
            return person;
        }

        public Personal GetPersonByUser(Guid PK_User)
        {
            var person = _context.Personals.Where(person => person.FK_User.PK_User == PK_User).First();
            return person;
        }

        public bool RegisterPerson(Personal personal)
        {
            _context.Add(personal);
            var res = _context.SaveChanges();
            if(res > 0)
                return true;
            else 
                return false;
        }

        public bool SavePerson(Personal person)
        {
            throw new NotImplementedException();
        }
    }
}
