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

        void Save();
        
        Personal GetPerson(int id);

        Address GetPersonalAddress(int id);
        
        Personal GetPersonByUser(Guid PK_User);

        bool RegisterPerson(Personal personal);
       
        bool SavePerson(Personal person);
    }
}
